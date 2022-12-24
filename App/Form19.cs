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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        transation_dataaDAL dal = new transation_dataaDAL();

        private void dgvDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Let's Add the Dunctionality to Search the Donors

            //1. Get the Keywords Typed on the Search TExt Box
            string keywords = txtSearch.Text;

            // Check Whether the Search TExtBox is Empty or Not
            if (keywords != null)
            {
                //Display the information of Donors Based on Keywords
                DataTable dt = dal.Search(keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                //DIsplay all the Donors
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }
    }
}
