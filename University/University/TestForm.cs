using Model;
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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            DyTest dyTest = new DyTest();
            dyTest.Connect();
            List<Test> tests;
            tests = dyTest.GetAll();
            dataGridView1.Rows.Clear();
            for (int i=0;i<tests.Count;i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = tests[i].test_id;
                dataGridView1.Rows[i].Cells[2].Value = Convert.ToString(tests[i].Value);
                dataGridView1.Rows[i].Cells[3].Value = tests[i].student;
                dataGridView1.Rows[i].Cells[4].Value = tests[i].Type_test;
                dyTest.disconnect();

            }
        }
    }
}
