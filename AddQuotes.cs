using DeskInc.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeskInc
{
    public partial class AddQuotes : Form
    {
        readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Desk.Inc;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int CellId;
        string custName;
        string custLname;
        string custAddress;
        decimal width;
        decimal depth;
        int drawers;
        int material;
        int rushDays;
        int rush;
        decimal total;
        decimal rushPrice;
        decimal totalPrice;
        decimal MatPrice;
        int rushId;
        int id;
        decimal priceMat;
        decimal rushAmount;


        public AddQuotes()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            MatDataSource();
            RushDataSource();
            Display();


        }

        private void MatDataSource()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Material ORDER BY MatName; ", con);
                adpt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                MatComboBox.DisplayMember = "MatName";
                MatComboBox.ValueMember = "MatId";
                MatComboBox.DataSource = dt;
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

        private void RushDataSource()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM RushOrder  ORDER BY RushDays DESC; ", con);
                adpt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adpt.Fill(dt);
                DeliveryCmBox.DisplayMember = "RushDays";
                DeliveryCmBox.ValueMember = "RushId";
                DeliveryCmBox.DataSource = dt;

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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtAddress.Text == "" || textLstNme.Text == "")
                {
                    MessageBox.Show("No feild must be empty");
                }
                else
                {

                    custName = txtName.Text;
                    custLname = textLstNme.Text;
                    custAddress = txtAddress.Text;
                    width = widthNum.Value;
                    depth = depthNum.Value;
                    decimal area = width * depth;
                    drawers = (int)drawersNum.Value;
                    DataRowView selectedMat = (DataRowView)MatComboBox.SelectedItem;
                    int idSeleMat = Convert.ToInt32(selectedMat["MatId"]);
                    material = idSeleMat;


                    DataRowView selectedRush = (DataRowView)DeliveryCmBox.SelectedItem;
                    int idRow = Convert.ToInt32(selectedRush["RushId"]);
                    rush = idRow;
                    MatPrice = GetMatPrice(material);
                    rushPrice = GetRushPrice(rush);
                    drawers = (int)drawersNum.Value;
                    totalPrice = GetTotalPrice(area, rushPrice, MatPrice, drawers);
                    DateTime date = DateTime.Now;
                    con.Open();
                    cmd = new SqlCommand($"INSERT INTO DeskQoute (userId,matId,rushId,name,lastName,width,depth,drawers,Total,date,address) VALUES('{Session.User.UserId}','{material}','{rush}','{custName}','{custLname}',{width},'{depth}','{drawers}','{totalPrice}','{date}','{custAddress}')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully saved a qoute");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
                Display();
                Clear();
            }


        }

        /* private int GetMatId(string matN)
         {

                 con.Open();
                 cmd = new SqlCommand("SElECT MatId FROM Material WHERE MatName =@name  ", con);
                 cmd.Parameters.AddWithValue("@name", matN);
                 adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                 adpt.Fill(ds);
                 int count = ds.Tables[0].Rows.Count;
                 if (count > 1 || count<1)
                 {
                     MessageBox.Show("Cant's find the Material");
                 }
                 SqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                      id = Convert.ToInt32(reader["MatId"]);

                 }
                 con.Close();
                 return id;


         }*/

        private decimal GetMatPrice(int matN)
        {

            con.Open();
            cmd = new SqlCommand("SElECT * FROM Material WHERE MatId =@name  ", con);
            cmd.Parameters.AddWithValue("@name", matN);
            adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count > 1 || count < 1)
            {
                MessageBox.Show("Cant's find the Material");
            }
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                priceMat = Convert.ToDecimal(reader["MatPrice"]);

            }

            con.Close();
            return priceMat;
        }

        private int GetRushId(int Rush)
        {

            con.Open();
            cmd = new SqlCommand("SElECT RushId FROM RushOrder WHERE RushDays =@name  ", con);
            cmd.Parameters.AddWithValue("@name", Rush);
            adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count > 1 || count < 1)
            {
                MessageBox.Show("Cant's find the Rush");
            }
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rushId = Convert.ToInt32(reader["RushId"]);

            }
            con.Close();
            return rushId;


        }
        private decimal GetRushPrice(int Rush)
        {
            con.Open();
            cmd = new SqlCommand("SElECT RushAmount FROM RushOrder WHERE RushId =@name  ", con);
            cmd.Parameters.AddWithValue("@name", Rush);
            adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            int count = ds.Tables[0].Rows.Count;
            if (count > 1 || count < 1)
            {
                MessageBox.Show("Cant's find the Amount");
            }
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rushAmount = Convert.ToDecimal(reader["RushAmount"]);

            }

            con.Close();
            return rushAmount;
        }





        private decimal GetTotalPrice(decimal area, decimal rushPrice, decimal matAmount, int drawers)
        {
            const int SMALL_DESK_SIZE = 1000;
            const decimal BASE_PRICE = 200;
            const decimal EXTRA_PRICE = 1;
            decimal deskPrice = 0;
            decimal totalPrice;
            decimal drawersPrice;

            if (area < SMALL_DESK_SIZE)
            {
                deskPrice += BASE_PRICE;
                drawersPrice = drawers * 50;
                totalPrice = drawersPrice + deskPrice + rushPrice + matAmount;
                return totalPrice;

            }
            else
            {
                decimal extraPrice = (area - SMALL_DESK_SIZE) * EXTRA_PRICE;
                deskPrice = extraPrice + BASE_PRICE;
                drawersPrice = 50 * drawers;
                totalPrice = deskPrice + rushPrice + matAmount + drawersPrice;
                return totalPrice;
            }



        }

        private void Display()
        {
            try
            {
                con.Open();
                dt = new DataTable();
                cmd = new SqlCommand("SELECT * FROM DeskQoute;", con);
                adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't fetch data");
            }
            finally
            {
                con.Close();
            }

        }

        private void AddQuotes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CellId = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            textLstNme.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            widthNum.Value = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            depthNum.Value = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
            drawersNum.Value = decimal.Parse(dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString());
            MatComboBox.SelectedValue = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            DeliveryCmBox.SelectedValue = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();


        }

        private void Clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            textLstNme.Text = "";

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                custName = txtName.Text;
                custLname = textLstNme.Text;
                custAddress = txtAddress.Text;
                width = widthNum.Value;
                depth = depthNum.Value;
                decimal area = width * depth;
                drawers = (int)drawersNum.Value;
                DataRowView selectedMat = (DataRowView)MatComboBox.SelectedItem;
                int idSeleMat = Convert.ToInt32(selectedMat["MatId"]);
                material = idSeleMat;


                DataRowView selectedRush = (DataRowView)DeliveryCmBox.SelectedItem;
                int idRow = Convert.ToInt32(selectedRush["RushId"]);
                rush = idRow;
                MatPrice = GetMatPrice(material);
                rushPrice = GetRushPrice(rush);
                drawers = (int)drawersNum.Value;
                totalPrice = GetTotalPrice(area, rushPrice, MatPrice, drawers);
                DateTime date = DateTime.Now;

                con.Open();
                cmd = new SqlCommand($"UPDATE DeskQoute SET userId='{Session.User.UserId}',matId='{material}',rushId='{rush}',name='{custName}',lastName='{custLname}',width='{width}',depth='{depth}',drawers='{drawers}',Total='{totalPrice}',date='{date}',address='{custAddress}' WHERE deskQtId='{CellId}' ;", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                Display();
                Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand($"DELETE FROM DeskQoute WHERE deskQtId='{CellId}' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been deleted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                Clear();
                Display();
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
