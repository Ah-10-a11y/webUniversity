using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Speciality
    {
        public string speciality_name { get; set; }
        public int speciality_id { get; set; }


        public Speciality(int speciality_id, string name)
        {
            this.speciality_id = speciality_id;
            this.speciality_name = name;
           


        }

        public override string ToString()
        {
            return speciality_id.ToString() + "" + speciality_name;
        }
    }
}
