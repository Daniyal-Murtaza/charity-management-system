using SPF.BLL;
using SPF.DAL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPF
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        //Create a Static String method to save the username
        public static string loggedInUser;

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Write the Code to Login our Application
            //1. Get the username and password from login form
            l.cnic = textBox1.Text;
            l.password = textBox2.Text;
            // l.usertype = radioButton1.Text;

            //Check the Login Credentials
            bool isSuccess = dal.loginCheck(l);

            //Check whehter the login is success or not
            //If login is success then isSuccess will be true else it will be false
            if (isSuccess == true)
            {
                //Login Success
                //Display Success Message
                MessageBox.Show("Login Successful.");

                //Save the username in loggedInuser Stattic MEthod
                loggedInUser = l.cnic;

                if (radioButton1.Checked == true)
                {
                    this.Hide();
                    Form13 f13 = new Form13();
                    f13.ShowDialog();
                }
                else if (radioButton2.Checked == true)
                {
                    this.Hide();
                    Form18 f18 = new Form18();
                    f18.ShowDialog();
                }
                else if (radioButton3.Checked == true)
                {
                    this.Hide();
                    Form23 f23 = new Form23();
                    f23.ShowDialog();
                }
            }
            else
            {
                //Login Failed
                //Display the Error Message
                MessageBox.Show("Login Failed. Try Again.");
            }
        }
    

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
