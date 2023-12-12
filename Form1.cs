using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeskInc.Auth;

namespace DeskInc
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            label1.Text = Session.User.UserName;
            label2.Text = Session.User.UserId.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuotes addQuotes = new AddQuotes();
            addQuotes.Show();
            this.Hide();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        
    }
}
