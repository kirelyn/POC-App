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
        string myConnectionString = "server=localhost;database=mydatabase;uid=admin;pwd=1039569yargi;";
        private void button1_Click(object sender, EventArgs e)
        {
            int cid = 10;
            string connectionString = null;
            MySqlConnection con;
            connectionString = "server=localhost;database=mydatabase;uid=admin;pwd=1039569yargi;";
            con = new MySqlConnection(connectionString);

            ArrayList courses = new ArrayList();
            ArrayList contactStudentCourse = new ArrayList();

            try
            {
                con.Open();
                //MessageBox.Show("Connetion Successful!");
                //string sql = "SELECT class_id FROM mydatabase.class_schedule WHERE student_id=" + cid.ToString() + ";";
                string sql = "SELECT student_id FROM mydatabase.class_schedule WHERE class_id=410 AND student_id!=" + cid.ToString() + ";";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    courses.Add(reader[0]);
                    //int result = Convert.ToInt32(reader[0]);
                    //System.Diagnostics.Debug.WriteLine(result);
                }
                reader.Close();
                /*
                for (int i = 0; i < courses.Count; i++)
                {
                    sql = "SELECT student_id FROM mydatabase.class_schedule WHERE class_id=" + courses[i].ToString() + " AND student_id!=" + cid.ToString() + ";";
                    cmd = new MySqlCommand(sql, con);
                    reader = cmd.ExecuteReader();
                    
                    while (reader.Read() && reader != null)
                    {
                        contactStudentCourse.Add(reader[0]);
                    }
                    
                }
                */
                for (int i = 0; i < courses.Count; i++)
                {
                    System.Diagnostics.Debug.WriteLine(courses[i].ToString());
                }
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
