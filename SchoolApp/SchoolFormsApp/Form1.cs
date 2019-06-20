using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary; //add library

namespace SchoolFormsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void BtnPushToTest_Click(object sender, EventArgs e)
		{
			//		hard coded practice
			//var testSchool = new SchoolLibrary.School(); //SchoolLibrary not necessary once "using library included above"
			//testSchool.Name = "Central City High";
			//testSchool.TwitterAddress = "@CentralCityHigh"; //_twitter... is private!
			//must start with "@" or excpetion thrown!

			//		real user values
			var testSchool = new School();
			testSchool.Name = txtName.Text;
			testSchool.Address = txtAddress.Text;
			testSchool.City = txtCity.Text;
			testSchool.State = txtState.Text;
			testSchool.Zip = txtZip.Text;
			testSchool.PhoneNumber = txtPhone.Text;
			try
			{
				testSchool.TwitterAddress = txtTwitter.Text; // fix exception
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message); // throw exception message
			}

			MessageBox.Show(testSchool.ToString());

			//var student = new Person(); illegal! no instiation allowed due to keyword "abstract"
			var teacher = new Teacher(); //test only - remove later
			
		}

		private void BtnTestTeacher_Click(object sender, EventArgs e)
		{
			var teacher = new Teacher();
			var gp = teacher.ComputeGradeAverage();
			MessageBox.Show("the teacher's grade average is " + gp);
		}

		private void BtnTestStudent_Click(object sender, EventArgs e)
		{
			var student = new Student();
			var gp = student.ComputeGradeAverage();
			MessageBox.Show("the student's grade average is " + gp);
		}
	}
}
