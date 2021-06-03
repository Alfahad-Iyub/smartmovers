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
    public partial class Customer : Form
    {

        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=FAHAD\FAHADSQL;Initial Catalog=Smart Movers;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Customer_ID = textBox1.Text;
                string C_Name = textBox2.Text;
                string C_Address = textBox3.Text;
                string C_Type = comboBox1.Text;

                string query_insert = "insert into Customer values('" + Customer_ID + "','" + C_Name + "','" + C_Address + "','" + C_Type + "')";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Customer_ID = textBox1.Text;
                string C_Name = textBox2.Text;
                string C_Address = textBox3.Text;
                string C_Type = comboBox1.Text;

                string deletesql = "update Customer set C_Name='" + C_Name + "',C_Address='" + C_Address + "',C_Type='" + C_Type + "'";
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
                string Customer_ID = textBox1.Text;
                string C_Name = textBox2.Text;
                string C_Address = textBox3.Text;
                string C_Type = comboBox1.Text;

                string deletesql = "delete from Customer where Customer_ID='" + Customer_ID + "'";
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
                string query_select = "SELECT * FROM dbo.[Customer] WHERE Customer_ID = '" + int.Parse(textBox1.Text) + "'";
                SqlCommand cmnd = new SqlCommand(query_select, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Search successfull !");
                SqlDataReader smart = cmnd.ExecuteReader();

                while (smart.Read())
                {
                    textBox2.Text = smart[1].ToString();
                    textBox3.Text = smart[2].ToString();
                    comboBox1.Text = smart[3].ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu obj = new MainMenu();
            obj.Show();
        }
    }
}
