using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BCryptNet = BCrypt.Net.BCrypt;
using DeskInc.Auth;


namespace DeskInc
{
    public partial class LogIn : Form
    {
        string firstName;
        string password;
        int id;
        string passwordHarshed;
        bool isPassword;
        readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Desk.Inc;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public LogIn()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if(LUserNameTextBox.Text =="" || TxtPassword.Text == "") 
                {
                    MessageBox.Show("All  fields must be filled ");
                }
                firstName = LUserNameTextBox.Text;
                password = TxtPassword.Text; 
                con.Open();
                cmd = new SqlCommand("SELECT UserId,FirstName,Password FROM Users WHERE FirstName = @firstName ",con);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                         id = Convert.ToInt32(reader["UserId"]);
                         passwordHarshed = reader["Password"].ToString();
                    }
                    isPassword = BCryptNet.Verify(password, passwordHarshed);
                    
                    if (!isPassword)
                    {
                        MessageBox.Show($"Password is wrong  ");
                 
                    }
                    else
                    {
                        Session.User = new User(firstName, id, true);
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Can't find the User try to check the Username if to see if u made mistakes");
                   
                }
    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }
    } 
}
