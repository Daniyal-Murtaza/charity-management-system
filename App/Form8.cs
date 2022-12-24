using SPF.BLL;
using SPF.DAL;
using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        education_relief_volunteerBLL l = new education_relief_volunteerBLL();
        education_relief_volunteerDAL dal = new education_relief_volunteerDAL();
        private void button1_Click(object sender, EventArgs e)
        {
            l.cnic = textBox1.Text;
            l.firstname = textBox2.Text;
            l.lastname = textBox3.Text;
            l.email = textBox4.Text;
            l.phone = textBox5.Text;
            l.password = textBox6.Text;
            // l.usertype = radioButton1.Text;

            //Check the Login Credentials
            bool isSuccess = dal.loginCheck(l);

            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 f0 = new Form0();
            f0.ShowDialog();
        }
    }
}
