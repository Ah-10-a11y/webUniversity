using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAO
{
    public class DySpeciality
    {
        private string connect = "Data Source=B310-03;Initial Catalog=University;Persist Security Info=True;User ID=Ahmed77;Password=Ahmed88";
        SqlConnection conn;

        public List<Speciality> All { get; set; }
        public Speciality speciality { get; private set; }

        string sql = "select * from  Specialities";

        public void Connect()
        {
            conn = new SqlConnection(connect);
            conn.Open();
        }

        public List<Speciality> Execute(string sql, SqlParameter sqlParameter = null)
        {
            List<Speciality> specialitus = new List<Speciality>();
            Connect();
            SqlCommand command = new SqlCommand(sql, conn);
            if (sqlParameter != null)
            {
                command.Parameters.Add(sqlParameter);
            }

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                Speciality speciality = new Speciality(reader.GetInt32(0),
                   reader.GetString(1));

                specialitus.Add(speciality);

            }
            return specialitus;
        }

        public List<Speciality> GetAll()
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
