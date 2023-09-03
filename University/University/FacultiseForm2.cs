using MyDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class FacultiseForm2 : Form
    {
        Dyfaculties dyfaculties = new Dyfaculties();
        public FacultiseForm2()
        {
            InitializeComponent();
            dyfaculties.Connect();

        }
        public void ShowFaculties()
        {
            
          

        }

        private void FacultiseForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
