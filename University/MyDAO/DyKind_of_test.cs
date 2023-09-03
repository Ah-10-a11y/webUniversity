using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAO
{
     public class DyKind_of_test
    {
        private string connect = "Data Source=B310-03;Initial Catalog=University;Persist Security Info=True;User ID=Ahmed77;Password=Ahmed88";
        SqlConnection conn;
        public List<Kind_of_test> All { get; set; }

        string sql = "select * from kind_of_test";

        public void Connect()
        {
            conn = new SqlConnection(connect);
            conn.Open();
        }
        public List<Kind_of_test> Execute(string sql, SqlParameter sqlParameter = null)
        {
            List<Kind_of_test> students = new List<Kind_of_test>();
            Connect();
            SqlCommand command = new SqlCommand(sql, conn);
            if (sqlParameter != null)
            {
                command.Parameters.Add(sqlParameter);
            }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                Kind_of_test dyKind_of_test = new Kind_of_test(reader.GetInt32(0),
                   reader.GetString(1));

                students.Add(dyKind_of_test);
            
            }
            return students;
        }
        public List<Kind_of_test> GetAll()
        {
            return Execute(sql);
        }
        public void disconnect()
        {
            if (conn != null)
                conn.Close();
        }
    }

    }

