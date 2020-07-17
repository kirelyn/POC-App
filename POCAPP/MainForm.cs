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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        string myConnectionString = "server=localhost;database=;uid=;pwd=;";
        private void btnIdEnter_Click(object sender, EventArgs e)
        {

                int id = Int32.Parse(TBStudentID.Text);
                string connectionString = "server=localhost;database=;uid=;pwd=;";
                MySqlConnection con = new MySqlConnection(connectionString);

                try
                {
                    con.Open();
                    string sql = "SELECT d.id, SUM(d.c) AS Count FROM( SELECT s.id, count(*) AS c FROM student AS s join class_schedule AS csched on s.id = csched.student_id JOIN(SELECT class_id FROM class_schedule WHERE student_id =" + id.ToString() + ") AS classes WHERE csched.class_id = classes.class_id AND s.id !=" + id.ToString() + " GROUP BY s.id UNION ALL SELECT s.id, count(*) AS count2 FROM student AS s JOIN club_schedule AS clubsched ON s.id = clubsched.student_id JOIN(SELECT club_id FROM club_schedule WHERE student_id =" + id.ToString() + ") AS clubs WHERE clubsched.club_id = clubs.club_id AND s.id != " + id.ToString() + " GROUP BY s.id ) AS d GROUP BY d.id;";
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
    }
}
