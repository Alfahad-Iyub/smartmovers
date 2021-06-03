using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMovers
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer obj = new Customer();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment obj = new Payment();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Depot obj = new Depot();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product obj = new Product();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Job obj = new Job();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Load obj = new Load();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transport obj = new Transport();
            obj.Show();
        }
    }
}
