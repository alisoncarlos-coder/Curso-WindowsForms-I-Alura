using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsLib.Databases
{
    public class LocalDBContext
    {

        public readonly string _connectionString;
        public readonly SqlConnection _sqlConnection;

        public LocalDBContext()
        {
            try
            {
                _connectionString = ConfigurationManager.ConnectionStrings["FicharioConnectionString"].ConnectionString;
                _sqlConnection = new SqlConnection(_connectionString);
                _sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string SQLCommand(string sql)
        {
            try
            {
                var myCommand = new SqlCommand(sql, _sqlConnection);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SQLQuery(string sql)
        {
            var dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(sql, _sqlConnection);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public void Close()
        {
            _sqlConnection.Close();
        }

    }
}
