using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace DeskInc
{
    public partial class Payment : Form
    {
        readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Desk.Inc;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        System.Data.DataTable dt;
        int DeskQouteId;
        decimal Price;
        decimal PaymentAmount;
        decimal Change;
        int paymentId;
        public Payment()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            loadQoutes();
            LoadPayments();

        }

        private void loadQoutes()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM DeskQoute;", con);
                adpt = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;

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

        private void LoadPayments()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT d.name  'Customer Name',d.address,d.width,d.depth, d.drawers,p.paymentId,p.deskQtId,p.Amount,p.Change ,p.date FROM DeskQoute d INNER JOIN Payment p ON d.deskQtId= p.deskQtId ORDER BY date; ", con);
                adpt = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                adpt.Fill(dt);
                paymentGrid.DataSource = dt;
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

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Tag = this;
            signUp.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Changelabel.Hide();
                DeskQouteId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Price = decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());

                DeskQouteNum.Value = DeskQouteId;
                PriceDown.Value = Price;
                AmountNumb.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.HelpLink, ex.Message);

            }


        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();

        }

        private decimal calculateChange(decimal amnt , decimal price)
        {
            decimal change = amnt - price;
            return change;
        }
             
        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeskQouteNum.Value < 0 || PriceDown.Value <0 || AmountNumb.Value <PriceDown.Value)
                {
                    MessageBox.Show("All fields must be filled");
                }
                else
                {
                    DeskQouteId = (int)DeskQouteNum.Value;
                    DateTime date = DateTime.Now;
                    Price = PriceDown.Value;
                    PaymentAmount = AmountNumb.Value;
                    Change = calculateChange(PaymentAmount, Price);
                    con.Open();
                    cmd = new SqlCommand($"INSERT INTO Payment (deskQtId,Amount,date,Change) VALUES('{DeskQouteId}','{PaymentAmount}','{date}','{Change}')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully paid the Desk");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,ex.HelpLink);
            }
            finally
            {
                con.Close();
                Changelabel.Text = "Change: "+Convert.ToString(Change);
                Changelabel.Show();
                LoadPayments();

            }

           
        }

        private void paymentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                paymentId = int.Parse(paymentGrid.Rows[e.RowIndex].Cells[5].Value.ToString());
                DeskQouteNum.Value = int.Parse(paymentGrid.Rows[e.RowIndex].Cells[6].Value.ToString());
                AmountNumb.Value = decimal.Parse(paymentGrid.Rows[e.RowIndex].Cells[7].Value.ToString());
                Change = decimal.Parse(paymentGrid.Rows[e.RowIndex].Cells[8].Value.ToString());
                PriceDown.Value = AmountNumb.Value - Change;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.HelpLink);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditBtn.UseWaitCursor = true;
                con.Open();
                DeskQouteId = (int)DeskQouteNum.Value;
                Price = PriceDown.Value;
                PaymentAmount = AmountNumb.Value;
                Change = calculateChange(PaymentAmount,Price);
                DateTime date = DateTime.Now;
                cmd = new SqlCommand($"Update Payment SET deskQtId='{DeskQouteId}',Amount='{PaymentAmount}',date= '{date}',Change='{Change}' WHERE paymentId='{paymentId}';", con);
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HelpLink);
            }
            finally
            {
                con.Close();
                Changelabel.Text ="Change: "+ Convert.ToString(Change);
                Changelabel.Visible = true;
                LoadPayments();
                EditBtn.UseWaitCursor = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand($"DELETE FROM Payment WHERE paymentId='{paymentId}'; ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The payment has been deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HelpLink);
            }
            finally
            {
                con.Close();
                LoadPayments();

            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand($"SELECT * FROM DeskQoute WHERE name LIKE '%{SearchTxt.Text}%' OR lastName LIKE '%{SearchTxt.Text}%'  ", con);
                adpt = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HelpLink);
            }
            finally
            {
                con.Close();
            }
        }

        private void PayExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application Excell = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excell.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excell.ActiveSheet;
                Excell.Visible = true;

                for (int j = 2; j <= paymentGrid.Rows.Count; j++)
                {
                    for (int i = 1; i <= 1; i++)
                    {
                        ws.Cells[j, i] = paymentGrid.Rows[j - 2].Cells[i - 1].Value;

                    }

                }
                for (int i = 1; i < paymentGrid.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = paymentGrid.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < paymentGrid.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < paymentGrid.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = paymentGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch(Exception ex )
            {
               Console.WriteLine( ex.HelpLink);
            }
            

        }

        private void QExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application Excell = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = Excell.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excell.ActiveSheet;
                Excell.Visible = true;

                for (int j = 2; j <= dataGridView1.Rows.Count; j++)
                {
                    for (int i = 1; i <= 1; i++)
                    {
                        ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;

                    }

                }
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.HelpLink);
            }

        }
    }
}
