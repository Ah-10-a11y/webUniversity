using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Test
    {

        public int test_id { get; set; }
        public DateTime Date_test { get; set; }
        public int Value { get; set; }
        public Student student { get; set; }
        public int Type_test { get; set; }


        public Test(int id, DateTime Date_test, int Value, Student student, int Type_test)
        {

            test_id = id;
            this.Date_test = Date_test;
            this.Value = Value;
            this.student =student;
            this.Type_test = Type_test;


        }

        public Test()
        {
        }

        public override string ToString()
        {
            return test_id.ToString() + "" + Value;
        }
    }
}



