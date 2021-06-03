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
    public partial class Depot : Form
    {
        public Depot()
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
                string Depot_ID = textBox1.Text;
                string Transport_ID = textBox2.Text;
                string Dep_Name = textBox3.Text;
                string Dep_Location = textBox4.Text;

                string query_insert = "insert into Depot values('" + Depot_ID + "','" + Dep_Name + "','" + Dep_Location + "','" + Transport_ID + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Depot_ID = textBox1.Text;
                string Transport_ID = textBox2.Text;
                string Dep_Name = textBox3.Text;
                string Dep_Location = textBox4.Text;

                string deletesql = "delete from Depot where Depot_ID='" + Depot_ID + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Depot_ID = textBox1.Text;
                string Transport_ID = textBox2.Text;
                string Dep_Name = textBox3.Text;
                string Dep_Location = textBox4.Text;

                string deletesql = "update Depot set Dep_Name='" + Dep_Name + "',Dep_Location='" + Dep_Location + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query_select = "SELECT * FROM dbo.[Depot] WHERE Depot_ID = '" + int.Parse(textBox1.Text) + "'";
                SqlCommand cmnd = new SqlCommand(query_select, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Search successfull !");
                SqlDataReader smart = cmnd.ExecuteReader();

                while (smart.Read())
                {
                    textBox2.Text = smart[3].ToString();
                    textBox3.Text = smart[1].ToString();
                    textBox4.Text = smart[2].ToString();
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
