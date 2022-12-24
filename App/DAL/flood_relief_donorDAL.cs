using SPF.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPF.DAL
{
    internal class flood_relief_donorDAL
    {
        SqlConnection con = new SqlConnection("data source=DANIYAL-MURTAZA; database=BloodBankManagementSystem;Integrated Security=True;");

        public bool loginCheck(flood_relief_donorBLL l)
        {
            //Create a Boolean Variable and SEt its default value to false
            bool isSuccess = false;

            //Connecting DAtabase
            //SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Check Login BAsed on Usename and Password
                string sql = "insert into flood_relief_donor(cnic,firstname,lastname,email,password,phone) values(@cnic,@firstname,@lastname,@email,@password,@phone)" + "insert into donor_data(cnic,firstname,lastname,email,password,phone) values(@cnic,@firstname,@lastname,@email,@password,@phone)";

                //Create SQL Command to Pass the value to SQL Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Pass the value to SQL Query Using Parameters
                cmd.Parameters.AddWithValue("@cnic", l.cnic);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@firstname", l.firstname);
                cmd.Parameters.AddWithValue("@lastname", l.lastname);
                cmd.Parameters.AddWithValue("@phone", l.phone);
                cmd.Parameters.AddWithValue("@email", l.email);

                //SQl Data Adapeter to Get the Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //DataTable to Hold the data from database temporarily
                DataTable dt = new DataTable();

                //Filld the data from adapter to dt
                adapter.Fill(dt);

                //Chekc whether user exists or not
                if (dt.Rows.Count > 0)
                {
                    //User Exists and Login Successful
                    isSuccess = true;
                }
                else
                {
                    //Login Failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exception Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                con.Close();
            }

            return isSuccess;
        }


        #region SELECT to display data in DataGridView from database
        public DataTable Select()
        {
            // Create object to DataTAble to hold the data from database and return it
            DataTable dt = new DataTable();

            //Create object of SQL Connection to Connect DAtabase
            //SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write SQL Query to SElect the DAta from DAtabase
                string sql = "SELECT * FROM flood_relief_donor";

                //Create the SQlCommand to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Create SQl DAta Adapter to Hold the Data Temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open Database Connection
                con.Open();

                //Pass the Data from adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                con.Close();
            }

            return dt;
        }
        #endregion


        #region Method to Search Donors
        public DataTable Search(string keywords)
        {
            //1. SQL Connection to Connect DAtabase
            //SqlConnection conn = new SqlConnection(myconnstrng);

            //2. Create DataTable to hold the data Temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write the Code to Search Donors based on Keywords Typed on TextBox
                //Write SQL Query to SEarch Donors
                string sql = "SELECT * FROM flood_relief_donor";

                //Create SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //SQlDataAdapter to Save Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                con.Open();

                //Transfer the Data from SQL Data Adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close the DAtabase Connection
                con.Close();
            }

            return dt;
        }
        #endregion


    }
}
