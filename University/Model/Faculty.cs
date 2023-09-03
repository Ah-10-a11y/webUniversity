using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Faculty
    {
        public string faculties_name { get; set; }
        public int faculties_id { get; set; }

        public Faculty(string name, int faculties_id)
        {

            this.faculties_name = faculties_name;
            this.faculties_id = faculties_id;
        }

        public Faculty()
        {
        }
    }
}
