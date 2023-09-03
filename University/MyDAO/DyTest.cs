using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAO
{
    public class DyTest
    {
        private string connect = "Data Source=B310-03;Initial Catalog=University;Persist Security Info=True;User ID=Ahmed77;Password=Ahmed88";
        SqlConnection conn;
        public void Connect()
        {
            conn = new SqlConnection(connect);
            conn.Open();
        }
        public List<Test> Execute(string sql, SqlParameter sqlParameter = null)
        {
            List<Test> students = new List<Test>();
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
                DateTime dateTime = reader.GetDateTime(1);
                int value = int.Parse(reader.GetValue(2).ToString());
                int Id_Student = reader.GetInt32(3);
                string NameStudent = reader.GetString(4);
                string FacultyName = reader.GetString(5);
                int type_test = reader.GetInt32(6);
                string specialitinem = reader.GetString(7);
                string Kind_of_testnem = reader.GetString(8);
                int Id_Faculty = reader.GetInt32(9);
                int specialiti = reader.GetInt32(10);
                Faculty faculty = new Faculty(FacultyName, Id_Faculty);
                Speciality speciality = new Speciality(specialiti, specialitinem);
                Student student = new Student(Id_Student, NameStudent, faculty, speciality);
                Test test = new Test(id,dateTime, value, student , type_test);
                students.Add(test);
            }
            return students;
        }

        public List<Test> GetAll()
        {

            string sql = "SELECT t.id, t.date_test, t.value, t.id_student, s.Name as studentname, f.name as facultyname, " +
                "t.type_test ,sp.Name as specialitinem , k.Name as kind_of_test " +
                "FROM test t join student s on t.id_student = s.Id join faculties f on f.id = s.id_faculty  join specialities sp on sp.id = s.id_speciality  join kind_of_test k on k.id = t.type_test";
            return Execute(sql);
        }
        public void disconnect()
        {
            if (conn != null)
                conn.Close();
        }




    }
}
