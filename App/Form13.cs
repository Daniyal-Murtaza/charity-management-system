﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPF
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("data source=DANIYAL-MURTAZA; database=BloodBankManagementSystem;Integrated Security=True;");


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from flood_relief_donor UNION select * from education_relief_donor", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Display home Form
            this.Hide();
            Form15 f1 = new Form15();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 f19 = new Form19();
            f19.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Display home Form
            this.Hide();
            Form17 f1 = new Form17();
            f1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 f16 = new Form16();
            f16.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 f20 = new Form20();
            f20.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 f21 = new Form21();
            f21.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f1 = new Form12();
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form0 f0 = new Form0();
            f0.ShowDialog();
        }
    }
}
