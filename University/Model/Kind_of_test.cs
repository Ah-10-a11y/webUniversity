using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kind_of_test
    {
        public string Kind_of_test_name { get; set; }
        public int Kind_of_test_id { get; set; }


        public Kind_of_test(int id, string name)
        {
            this.Kind_of_test_name = name;
            this.Kind_of_test_id = id;
        }

        public override string ToString()
        {
            return Kind_of_test_id + "  " + Kind_of_test_name;
        }
    }
}
