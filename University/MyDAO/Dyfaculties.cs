using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAO
{
    public class Dyfaculties
    {
        private string connect = "Data Source=B310-03;Initial Catalog=University;Persist Security Info=True;User ID=Ahmed77;Password=Ahmed88";
        SqlConnection conn;

        public List<Faculty> All { get; set; }
        public Faculty  faculties { get; private set; }

        string sql = "select * from  faculties";


        public Dyfaculties()
        {

        }

        public void Connect()
        {
            conn = new SqlConnection(connect);
            conn.Open();
        }
        public List<Faculty> Execute(string sql, SqlParameter sqlParameter = null)
        {
            List<Faculty> faculties = new List<Faculty>();
            Connect();
            SqlCommand command = new SqlCommand(sql, conn);
            if (sqlParameter != null)
            {
                command.Parameters.Add(sqlParameter);
            }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Faculty dyfaculties = new Faculty(reader.GetString(1), reader.GetInt32(0));

               faculties.Add(dyfaculties);
            }
            return faculties;
        }
        public List<Faculty> GetAll()
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

    

