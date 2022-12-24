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
    internal class education_relief_volunteerDAL
    {
        SqlConnection con = new SqlConnection("data source=DANIYAL-MURTAZA; database=BloodBankManagementSystem;Integrated Security=True;");

        public bool loginCheck(education_relief_volunteerBLL l)
        {
            //Create a Boolean Variable and SEt its default value to false
            bool isSuccess = false;

            //Connecting DAtabase
            //SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Check Login BAsed on Usename and Password
                string sql = "insert into education_relief_volunteer(cnic,firstname,lastname,email,password,phone) values(@cnic,@firstname,@lastname,@email,@password,@phone)" +
                    "insert into volunteer_data(cnic,firstname,lastname,email,password,phone) values(@cnic,@firstname,@lastname,@email,@password,@phone)";

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
    }
}
