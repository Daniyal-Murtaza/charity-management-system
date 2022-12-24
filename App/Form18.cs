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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        donor_dataBLL d = new donor_dataBLL();
        donor_dataDAL dal = new donor_dataDAL();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                //We will write the code to Add new Donor
                //Step 1. Get the DAta from Manage Donors Form
                d.cnic = textBox1.Text;
                d.programs = comboBox1.Text;
                d.amount = textBox2.Text;

                //Step2: Inserting Data into Database
                //Create a Boolean Variable to Isnert DAta into DAtabase and check whether the data inserted successfully of not
                bool isSuccess = dal.Insert(d);

                //if the Data is inserted successfully then the values of isSuccess will be True else it will be false
                if (isSuccess == true)
                {
                    //Data Inserted Successfully
                    MessageBox.Show("Congratulations!!! Your Donations has been received :)");

                }
                else
                {
                    //FAiled to Insert Data
                    MessageBox.Show("Failed to receive your donation :(");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 f0 = new Form0();
            f0.ShowDialog();
        }
    }
}
