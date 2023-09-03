using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public Faculty faculty { get; set; }
        public Speciality speciality { get; set; }

        public Student(int id, string student_name, Faculty faculty, Speciality speciality)
        {
            name = student_name;
            this.id = id;
            this.faculty = faculty;
            this.speciality = speciality;

        }



        public override string ToString()
        {
            return id.ToString() + "" + name;
        }
    }

}

