using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DeskInc.Auth;

namespace DeskInc
{
    public partial class SignUp : Form
    {
         
        string fistName;
        string lastName;
        string password;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Desk.Inc;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public SignUp()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }


        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (fnameTxt.Text == "" || LNameTxt.Text == "" || passwordTxt.Text == "")
                {
                    MessageBox.Show("No field must be empty");

                }
                else
                {
                    fistName = fnameTxt.Text;
                    lastName = LNameTxt.Text;
                    PasswordHarsh passwordHarsh = new PasswordHarsh();
                    password = passwordHarsh.HarshPassword(passwordTxt.Text);
                    MessageBox.Show(password);


                    con.Open();

                    cmd = new SqlCommand("INSERT INTO Users (FirstName,LastName,Password) VALUES('" + fistName + "','" + lastName + "','" + password + "')", con);
                    cmd.ExecuteNonQuery();
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }

        }

        private void BtnLgn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
