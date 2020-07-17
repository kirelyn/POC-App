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

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

        //This is how the windows forms will be connected to the database. The connection will have to be personalized.
        string myConnectionString = "server=localhost;database=pocapp;uid=Kennedy;pwd=Django100.;";
        public void button1_Click(object sender, EventArgs e)
        {
            //int id = 10;
            string connectionString = "server=localhost;database=pocapp;uid=Kennedy;pwd=Django100.;";
            MySqlConnection con = new MySqlConnection(connectionString); 

            try
            {
                con.Open();
                MessageBox.Show("Connetion Successful!");
                string sql = "SELECT d.id, SUM(d.c) AS Count FROM( SELECT s.id, count(*) AS c FROM student AS s join class_schedule AS csched on s.id = csched.student_id JOIN(SELECT class_id FROM class_schedule WHERE student_id = 10) AS classes WHERE csched.class_id = classes.class_id AND s.id != 10 GROUP BY s.id UNION ALL SELECT s.id, count(*) AS count2 FROM student AS s JOIN club_schedule AS clubsched ON s.id = clubsched.student_id JOIN(SELECT club_id FROM club_schedule WHERE student_id = 10) AS clubs WHERE clubsched.club_id = clubs.club_id AND s.id != 10 GROUP BY s.id ) AS d GROUP BY d.id;";
                MySqlCommand command = new MySqlCommand(sql, con);
                MySqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    MessageBox.Show(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }

            con.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
