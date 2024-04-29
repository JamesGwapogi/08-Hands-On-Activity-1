using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int day = 1; day <= 31; day++)
            {

                comboBox1.Items.Add(day);

            }

            string[] months = new string[]
            {
                "January" , "Febuary" , "March" , "April" , "May" , "June" , "July" , "August" , "September" ,
                "October" , "November" , "December"
            };

            foreach (string month in months)
            {
                comboBox2.Items.Add(month);
            }


            for (int year = 1990; year <= 2024; year++)
            {

                comboBox3.Items.Add(year);
            }

            ArrayList courses = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string course in courses)
            {
                comboBox4.Items.Add(course);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.jpg)|.jpg| PNG files(.png)|.png| All Files (.)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK);
            }



        }
        private void button1_Click(object sender, EventArgs e)

        {

            string gender = " ";
            string DateOfBirth = "Date of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string MiddleName = textBox3.Text;
            string StudentName = "Student Name: " + LastName + " " + FirstName + " " + MiddleName;
            string program = "Program: " + comboBox4.Text;


            if (male.Checked)
            {
                gender = "Male";
            }
            else if (female.Checked)
            {
                gender = "Female";
            }





            if ((!(string.IsNullOrEmpty(gender))))
            {
                studentInfo(StudentName, gender, DateOfBirth, program);
            }

            else if (string.IsNullOrEmpty(DateOfBirth) && string.IsNullOrEmpty(gender))
            {
                studentInfo(StudentName, program);
            }

            else if (string.IsNullOrEmpty(MiddleName) && string.IsNullOrEmpty(DateOfBirth) && gender == " ")
            {
                studentInfo(FirstName, LastName, program);
            }
        }

        public void studentInfo(string studentName, string genders, string birthDate, string programs)
        {
            string gender = " ";
            string DateOfBirth = "Date of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string MiddleName = textBox3.Text;
            string StudentName = "Student Name: " + LastName + " " + FirstName + " " + MiddleName;
            string program = "Program: " + comboBox4.Text;

            MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\n" + "Gender: " + gender +
                "\nBirth Date: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text + "\nPrograms: " + comboBox4.Text);

        }
        public void studentInfo(string StudentNames, string programs)
        {
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string MiddleName = textBox3.Text;
            string StudentName = "Student Name: " + LastName + " " + FirstName + " " + MiddleName;
            string program = "Program: " + comboBox4.Text;

            MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\n" + "Programs: " + comboBox4.Text);



        }
        public void studentInfo(string LName, string FName, string programs)
        {
            string LastName = textBox1.Text;
            string FirstName = textBox2.Text;
            string StudentName = "Student Name: " + LastName + " " + FirstName;
            string program = "Program: " + comboBox4.Text;

            MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox3.Text + "\n" + "Programs: " + comboBox4.Text);


        }


    }



}