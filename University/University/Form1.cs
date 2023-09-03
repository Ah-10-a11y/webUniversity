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
    public partial class Form1 : Form
    {
       
       

        public List<Dyfaculties> Faculties { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DySpeciality dySpeciality = new DySpeciality();
            //dySpeciality.Connect();
            //List<Speciality> speciality;

            //speciality = dySpeciality.GetAll();
            ////richTextBox1.Clear();
            //dataGridView1.Rows.Clear();
            //for (int i = 0; i < speciality.Count; i++)
            //{
            //    //  richTextBox1.AppendText(speciality.ToString() + "\n");
            //    dataGridView1.Rows.Add();
            //    dataGridView1.Rows[i].Cells[0].Value = speciality[i].speciality_id;
            //    dataGridView1.Rows[i].Cells[1].Value = speciality[i].speciality_name;

            //}
            DyTest dyTest = new DyTest();
            dyTest.Connect();
            List<Test>test=dyTest.GetAll();
            dataGridView1.Rows.Clear();
            for (int i = 0 ; i < test.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = test[i].test_id;
                dataGridView1.Rows[i].Cells[1].Value = test[i].Date_test;
                dataGridView1.Rows[i].Cells[2].Value = test[i].Value;
                dataGridView1.Rows[i].Cells[3].Value = test[i].student;
                dataGridView1.Rows[i].Cells[4].Value = test[i].Type_test;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DyKind_of_test dyKind_Of_Test = new DyKind_of_test();
            dyKind_Of_Test.Connect();
            List<Kind_of_test> dyKind_of_test = dyKind_Of_Test.GetAll();
            richTextBox1.Clear();
            foreach (var Kind_of_test in dyKind_of_test)
            {
                richTextBox1.AppendText(Kind_of_test.ToString() + "\n");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DyStudent dyStudent = new DyStudent();

            List<Student> students = dyStudent.GetAll();
            richTextBox1.Clear();
            foreach (var student in students)
            {
                richTextBox1.AppendText(student.ToString() + "\n");
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Dyfaculties dyfaculties = new Dyfaculties();
            List<Faculty> faculty = dyfaculties.GetAll();
            richTextBox1.Clear();
            foreach (var Faculty in faculty)
            {
                richTextBox1.AppendText(faculty.ToString() + "\n");
            }
            

            
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
           // DyTest dyTest = new DyTest();
           
           //dyTest.Connect();
           // List<Test> Test = dyTest.GetAll();
           // //richTextBox1.Clear();
           // dataGridView1.Rows.Clear();
           // for (int i = 0; i < Test.Count; i++)
           // {
           //     //  richTextBox1.AppendText(speciality.ToString() + "\n");
           //     dataGridView1.Rows.Add();
           //     dataGridView1.Rows[i].Cells[0].Value = Test[i].test_id;
           //     dataGridView1.Rows[i].Cells[1].Value = Test[i].Date_test;
           //     dataGridView1.Rows[i].Cells[2].Value = Test[i].Value;
           //     dataGridView1.Rows[i].Cells[3].Value = Test[i].student;
           //     dataGridView1.Rows[i].Cells[4].Value = Test[i].Type_test;
           //  }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

