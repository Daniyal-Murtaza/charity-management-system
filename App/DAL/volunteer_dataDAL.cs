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
    internal class volunteer_dataDAL
    {
        SqlConnection con = new SqlConnection("data source=DANIYAL-MURTAZA; database=BloodBankManagementSystem;Integrated Security=True;");

        public bool loginCheck(volunteer_dataBLL l)
        {
            //Create a Boolean Variable and SEt its default value to false
            bool isSuccess = false;

            //Connecting DAtabase
            //SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Check Login BAsed on Usename and Password
                string sql = "insert into volunteer_data(cnic,firstname,lastname,email,password,phone) values(@cnic,@firstname,@lastname,@email,@password,@phone)";

                //Create SQL Command to Pass the value to SQL Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Pass the value to SQL Query Using Parameters
                cmd.Parameters.AddWithValue("@cnic", l.cnic);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@firstname", l.firstName);
                cmd.Parameters.AddWithValue("@lastname", l.lastName);
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



        public DataTable Select()
        {
            // Create object to DataTAble to hold the data from database and return it
            DataTable dt = new DataTable();

            //Create object of SQL Connection to Connect DAtabase
            //SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write SQL Query to SElect the DAta from DAtabase
                string sql = "SELECT * FROM volunteer_data";

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
                string sql = "SELECT * FROM volunteer_data";

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


        public bool Update(volunteer_dataBLL d)
        {
            //Create a Boolean Variable and SEt its Default Value to FAlse
            bool isSuccess = false;
            //Create SQLConnection to Connect DAtabase
            //SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a SQL Query to Update Donors
                string sql = "UPDATE volunteer_data SET firstName=@firstName, lastName=@lastName, email=@email, phone=@phone, cnic=@cnic, password=@password WHERE cnic=@cnic";

                //Create SQL Command Here
                SqlCommand cmd = new SqlCommand(sql, con);

                //Pass the Value to SQL Query
                cmd.Parameters.AddWithValue("@firstname", d.firstName);
                cmd.Parameters.AddWithValue("@lastname", d.lastName);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@phone", d.phone);
                cmd.Parameters.AddWithValue("@password", d.password);
                cmd.Parameters.AddWithValue("@cnic", d.cnic);

                //Open Database Connection
                con.Open();

                //Create an Integer Variable to check whether the query executed Successfully or not
                int rows = cmd.ExecuteNonQuery();

                //If the Query is Executed Successfully then its value will be greater than 0 else it will be 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CLose Database Connection
                con.Close();
            }

            return isSuccess;
        }
        public bool Delete(volunteer_dataBLL d)
        {
            //Create a Boolean variable and set its default value to false
            bool isSuccess = false;
            //Create SqlConnection To Connect DAtabase
            //SqlConnection conn = new SqlConnection(con);

            try
            {
                //Write the Query to Delete Donors from Database
                string sql = "DELETE FROM volunteer_data WHERE cnic=@cnic";

                //Create SQL Command
                SqlCommand cmd = new SqlCommand(sql, con);

                //Pass the Value to Sql Query using Parameters
                cmd.Parameters.AddWithValue("@cnic", d.cnic);

                //Open Database Connection
                con.Open();

                //Create an Integer VAriable to Check whether the query executed Successfully or Not
                int rows = cmd.ExecuteNonQuery();

                //If the Query executed succesfully then the value of rows will be greater than 0 else it will be 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Exeute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CLose Database Connection
                con.Close();
            }

            return isSuccess;
        }

        public bool Insert(volunteer_dataBLL d)
        {
            //Create a Boolean Variable and SEt its default value to false
            bool isSuccess = false;

            //Create SqlConnection to Connect Database
            //SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write the Query to INSERT data into database
                string sql = "insert into volunteer_task(cnic,programs,task) values(@cnic,@programs,@task)";
                //Create SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Pass the value to SQL Query
                cmd.Parameters.AddWithValue("@cnic", d.cnic);
                cmd.Parameters.AddWithValue("@programs", d.programs);
                cmd.Parameters.AddWithValue("@task", d.task);



                //Open DAtabase Connection
                con.Open();

                //Create an Integer Variable to Check whether the query was executed Successfully or Not
                int rows = cmd.ExecuteNonQuery();

                //If the Query is Executed Successfully the value of rows willb e greater than Zero else it will be Zero
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CLose Database Connection
                con.Close();
            }

            return isSuccess;
        }


    }
}
