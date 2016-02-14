using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        //Khai báo biến 
        private string _strConnectionString = @"Data Source=XZEROPC\SQLEXPRESS;Initial Catalog=NhaHangDB;Integrated Security=True";
        private SqlConnection _connection; 
        private string _error = ""; 
 
        //Khai báo property 
        public string Error  
        { 
            get { return _error; } 
            private set { _error = value; } 
        } 
 
        //Mở kết nối đến CSDL 
        public bool OpenConnect() 
        { 
            try 
            { 
                if (_connection == null)
                    _connection = new SqlConnection(_strConnectionString); 
 
                if(_connection.State == ConnectionState.Open) 
                    _connection.Close(); 
 
                _connection.Open(); 
 
                return true; 
            } 
            catch (SqlException ex) 
            { 
                Error = ex.Message; 
            } 
 
            return false; 
        } 
 
        //Đóng kết nối 
        public bool CloseConnect() 
        { 
            try 
            { 
                if (_connection != null) 
                    if (_connection.State == ConnectionState.Open) 
                        _connection.Close(); 
                return true; 
            } 
            catch (Exception ex) 
            { 
                Error = ex.Message; 
                return false; 
            } 
        } 
          
        //Thực thi truy vấn với các lệnh insert, update, delete 
        public bool SqlExcuteNonQuery(string procName, params SqlParameter[] SqlParameters) 
        { 
            try 
            { 
                if(OpenConnect()) 
                { 
                    SqlCommand SqlCommand = _connection.CreateCommand(); 
                    SqlCommand.CommandType = CommandType.StoredProcedure; 
                    SqlCommand.CommandText = procName; 
 
                    if(SqlParameters!=null) 
                        SqlCommand.Parameters.AddRange(SqlParameters);

                    SqlCommand.ExecuteNonQuery(); 
 
                    Error = ""; 
 
                    return true;    
                } 
 
                return false; 
            }
            catch (SqlException ex) 
            { 
                _error = ex.Message; 
 
                return false; 
            } 
            finally 
            { 
                CloseConnect(); 
            } 
             
        }

        //Thực thi truy vấn với lệnh Select, tra ve 1 bang
        public DataTable SqlExcuteQuery(string procName, params SqlParameter[] SqlParameters) 
        { 
            DataTable dt = null; 
            try 
            { 
                if (OpenConnect()) 
                { 
                    SqlCommand SqlCommand = _connection.CreateCommand(); 
                    SqlCommand.CommandType = CommandType.StoredProcedure; 
                    SqlCommand.CommandText = procName; 
                    if(SqlParameters!=null) 
                        SqlCommand.Parameters.AddRange(SqlParameters); 
         
                    var dbadapter = new SqlDataAdapter(SqlCommand); 
                    dt = new DataTable(); 
                    dbadapter.Fill(dt); 
 
                    Error = ""; 
                } 
            }
            catch (SqlException ex) 
            { 
                Error = ex.Message; 
            } 
            finally 
            { 
                CloseConnect(); 
            } 
 
            return dt; 
        } 
 
 
        //Trả về 1 giá trị đầu tiên 
        public object SqlExcuteScalar(string procName, params SqlParameter[] SqlParameters)  
        { 
            object value = null; 
            try 
            { 
                if (OpenConnect()) 
                { 
                    var SqlCommand = _connection.CreateCommand(); 
                    SqlCommand.CommandType = CommandType.StoredProcedure; 
                    SqlCommand.CommandText = procName;

                    if (SqlParameters != null)
                        SqlCommand.Parameters.AddRange(SqlParameters); 
 
                    value = SqlCommand.ExecuteScalar(); 
 
                    Error = ""; 
                } 
            }
            catch (SqlException ex) 
            { 
                Error = ex.Message; 
            } 
            finally 
            { 
                CloseConnect(); 
            } 
 
            return value; 
        } 
    }
}
