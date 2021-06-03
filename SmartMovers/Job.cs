using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartMovers
{
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu obj = new MainMenu();
            obj.Show();
        }

        SqlConnection con = new SqlConnection(@"Data Source=FAHAD\FAHADSQL;Initial Catalog=Smart Movers;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Job_ID = textBox1.Text;
                string Customer_ID = textBox2.Text;
                string Pickup_Location = textBox3.Text;
                string Delivery_Location = textBox4.Text;

                string query_insert = "insert into Job values('" + Job_ID + "','" + Pickup_Location + "','" + Delivery_Location + "','" + Customer_ID + "')";
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                cmnd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully !");
            }

            catch
            {
                MessageBox.Show("Error while saving");
            }

            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Job_ID = textBox1.Text;
                string Customer_ID = textBox2.Text;
                string Pickup_Location = textBox3.Text;
                string Delivery_Location = textBox4.Text;

                string deletesql = "update Job set Pickup_Location='" + Pickup_Location + "',Delivery_Location='" + Delivery_Location + "'";
                SqlCommand cmnd = new SqlCommand(deletesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully");
            }

            catch
            {
                MessageBox.Show("Error while saving");
            }

            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Job_ID = textBox1.Text;
                string Customer_ID = textBox2.Text;
                string Pickup_Location = textBox3.Text;
                string Delivery_Location = textBox4.Text;

                string deletesql = "delete from Job where Job_ID='" + Job_ID + "'";
                SqlCommand cmnd = new SqlCommand(deletesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Succesfully !");
            }

            catch
            {
                MessageBox.Show("Error while saving");
            }

            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query_select = "SELECT * FROM dbo.[Job] WHERE Job_ID = '" + int.Parse(textBox1.Text) + "'";
                SqlCommand cmnd = new SqlCommand(query_select, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Search successfull !");
                SqlDataReader smart = cmnd.ExecuteReader();

                while (smart.Read())
                {
                    textBox2.Text = smart[3].ToString();
                    textBox3.Text = smart[2].ToString();
                    textBox4.Text = smart[1].ToString();
                }
            }

            catch
            {
                MessageBox.Show("Error while searching");
            }

            finally
            {
                con.Close();
            }
        }
    }
}
