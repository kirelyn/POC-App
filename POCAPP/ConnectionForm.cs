using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace POCAPP
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

        //This is how the windows forms will be connected to the database. The connection will have to be personalized.
        string myConnectionString = "server=localhost;database=databasename;uid=username;pwd=password;";
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            MySqlConnection con;
            connectionString = "server=localhost;database=databasename;uid=username;pwd=password;";
            con = new MySqlConnection(connectionString);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
