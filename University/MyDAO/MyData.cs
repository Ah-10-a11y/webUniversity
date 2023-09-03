using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAO
{
    public class MyData
    {

        private string connect = "Data Source=B310-03;Initial Catalog=University;Persist Security Info=True;User ID=Ahmed77;Password=Ahmed88";
        SqlConnection conn;


        public void Connect()
        {
            conn = new SqlConnection(connect);
            conn.Open();

        }

        public List<Faculty> Execute(string sql, SqlParameter sqlParameter = null)
        {
            List<Faculty> MyDates = new List<Faculty>();
            Connect();
            SqlCommand command = new SqlCommand(sql, conn);
            if (sqlParameter != null)
            {
                command.Parameters.Add(sqlParameter);
            }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetValue(1).ToString();
                int id = Convert.ToInt32(reader.GetValue(0).ToString());
                Faculty Faculty = new Faculty(name, id);
                MyDates.Add(Faculty);
            }
            return MyDates;
        }


        public void disconnect()
        {
            if (conn != null)
                conn.Close();
        }

       

        public List<Faculty> GetAll()
        {
            string sql = "select * from faculties";
            return Execute(sql);
        }
        
    }
}

