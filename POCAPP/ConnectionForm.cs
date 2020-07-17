using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace POCAPP
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        

        //This is how the windows forms will be connected to the database. The connection will have to be personalized.
        string myConnectionString = "server=localhost;database=;uid=;pwd=;";
        public void button1_Click(object sender, EventArgs e)
        {
            
            //int id = 10;
            string connectionString = "server=localhost;database=;uid=;pwd=;";
            MySqlConnection con = new MySqlConnection(connectionString); 

            try
            {
                con.Open();
                MessageBox.Show("Connection Successful!");
                this.Hide();
                Form Form2 = new MainForm();
                Form2.ShowDialog();
                this.Close();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                Close();
            }

            con.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
