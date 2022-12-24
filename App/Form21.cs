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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        volunteer_tblBLL l = new volunteer_tblBLL();
        volunteer_tblDAL dal = new volunteer_tblDAL();

        private void button1_Click(object sender, EventArgs e)
        {

            // l.usertype = radioButton1.Text;

            //Check the Login Credentials
            l.cnic = textBox1.Text;

            bool isSuccess = dal.loginCheck(l);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Login Failed.");
                
            }
            else
            {
                this.Hide();
                Form14 f14 = new Form14();
                f14.ShowDialog();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }
    }
}
