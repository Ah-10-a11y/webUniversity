using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAO
{
    public class DyStudent
    {
        private string connect = "Data Source=B310-03;Initial Catalog=University;Persist Security Info=True;User ID=Ahmed77;Password=Ahmed88";
        SqlConnection conn;
        public void Connect()
        {
            conn = new SqlConnection(connect);
            conn.Open();
        }
        public List<Student> Execute(string sql, SqlParameter sqlParameter = null)
        {
            List<Student> students = new List<Student>();
            Connect();
            SqlCommand command = new SqlCommand(sql, conn);
            if (sqlParameter != null)
            {
                command.Parameters.Add(sqlParameter);
            }

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int id_Faculty = reader.GetInt32(2);
                string Faculty_Name = reader.GetString(3);
                Faculty faculty = new Faculty(name, id);
                int id_Speciality = reader.GetInt32(4);
                string Speciality_Name = reader.GetString(5);
                Speciality speciality = new Speciality(id, name);
                Student student = new Student(id, name, faculty, speciality);
                students.Add(student);
            }
            return students;
        }


        public List<Student> GetAll()
        {
            string sql = "select a.id,a.name,a.id_faculty,f.Name as Faculty_Name, id_speciality,s.Name as Speciality_Name " +
           "from Student a join faculties f on f.id=a.id_faculty join Specialities s on a.id_speciality= s.id";
            return Execute(sql);
        }
        public void disconnect()
        {
            if (conn != null)
                conn.Close();
        }


    }
}
