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
    public partial class XEnterId : Form
    {
        private MySqlConnection con = null;

        public XEnterId(MySqlConnection c)
        {
            InitializeComponent();
            xStudentIdText.Select();

            con = c;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void xFirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        string myConnectionString = "server=localhost;database=pocapp;uid=;pwd=;";
        private void button1_Click(object sender, EventArgs e)
        { 
            int id = Int32.Parse(xStudentIdText.Text);

            string connectionString = "server=localhost;database=pocapp;uid=;pwd=;";
            MySqlConnection con2 = new MySqlConnection(connectionString);
            // carrying over connection from the first form to avoid having two different opens. -- Johnny
            try
            {
                con2.Open();
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string sql = "SELECT d.id, SUM(d.c) AS Count FROM( SELECT s.id, count(*) AS c FROM student AS s join class_schedule AS csched on s.id = csched.student_id JOIN(SELECT class_id FROM class_schedule WHERE student_id =" + id + ") AS classes WHERE csched.class_id = classes.class_id AND s.id !=" + id + " GROUP BY s.id UNION ALL SELECT s.id, count(*) AS count2 FROM student AS s JOIN club_schedule AS clubsched ON s.id = clubsched.student_id JOIN(SELECT club_id FROM club_schedule WHERE student_id =" + id+ ") AS clubs WHERE clubsched.club_id = clubs.club_id AND s.id != " + id + " GROUP BY s.id ) AS d GROUP BY d.id;";
                MySqlCommand command = new MySqlCommand(sql, con);
                

                using (MySqlDataReader rdr = command.ExecuteReader())
                {


                    while (rdr.Read())
                    {
                        
                        int numPri = Int32.Parse(rdr.GetString(1));
                        int studentId = Int32.Parse(rdr.GetString(0));
                        string query = "UPDATE student SET priority =" + numPri + " WHERE id =" + studentId + ";";
                        MySqlCommand com2 = new MySqlCommand(query, con2);
                        com2.CommandText = "UPDATE student SET priority =" + numPri + " WHERE id =" + studentId + ";";
                        com2.Parameters.AddWithValue("priority", numPri);
                        com2.Connection = con2;
                        com2.ExecuteNonQuery();
                        MessageBox.Show("Data added");
                       // return true;
                    }
                    rdr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }

            con.Close();
        }

        private void XEnterId_Load(object sender, EventArgs e)
        {

        }
    }
}
