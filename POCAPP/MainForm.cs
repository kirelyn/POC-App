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
        private MySqlConnection con = null;
        public MainForm(MySqlConnection c)
        {
            InitializeComponent();
            con = c;

            listView.Items.Clear();
            ColumnHeader columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6;
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();

            columnHeader1.Text = "Column1";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 70;

            columnHeader2.Text = "Column2";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader2.Width = 70;

            columnHeader3.Text = "Column3";
            columnHeader3.TextAlign = HorizontalAlignment.Left;
            columnHeader3.Width = 70;

            columnHeader4.Text = "Column4";
            columnHeader4.TextAlign = HorizontalAlignment.Left;
            columnHeader4.Width = 100;

            columnHeader5.Text = "Column5";
            columnHeader5.TextAlign = HorizontalAlignment.Left;
            columnHeader5.Width = 100;

            columnHeader6.Text = "Column6";
            columnHeader6.TextAlign = HorizontalAlignment.Left;
            columnHeader6.Width = 70;

            listView.Columns.Add(columnHeader1);
            listView.Columns.Add(columnHeader2);
            listView.Columns.Add(columnHeader3);
            listView.Columns.Add(columnHeader4);
            listView.Columns.Add(columnHeader5);
            listView.Columns.Add(columnHeader6);

            listView.View = View.Details;
            listView.Columns[0].Text = "ID";
            listView.Columns[1].Text = "First Name";
            listView.Columns[2].Text = "Last Name";
            listView.Columns[3].Text = "Phone Number";
            listView.Columns[4].Text = "Email";
            listView.Columns[5].Text = "Priority";
        }

        private void btnIdEnter_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(TBStudentID.Text);
            string connectionString = "server=localhost;database=;uid=;pwd=;";
            MySqlConnection con2 = new MySqlConnection(connectionString);

            try
            {
                con2.Open();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string sql = "SELECT d.id, SUM(d.c) AS Count FROM( SELECT s.id, count(*) AS c FROM student AS s join class_schedule AS csched on s.id = csched.student_id JOIN(SELECT class_id FROM class_schedule WHERE student_id =" + id.ToString() + ") AS classes WHERE csched.class_id = classes.class_id AND s.id !=" + id.ToString() + " GROUP BY s.id UNION ALL SELECT s.id, count(*) AS count2 FROM student AS s JOIN club_schedule AS clubsched ON s.id = clubsched.student_id JOIN(SELECT club_id FROM club_schedule WHERE student_id =" + id.ToString() + ") AS clubs WHERE clubsched.club_id = clubs.club_id AND s.id != " + id.ToString() + " GROUP BY s.id ) AS d GROUP BY d.id;";
                MySqlCommand command = new MySqlCommand(sql, con);
                using (MySqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int numPri = Int32.Parse(rdr.GetString(1));
                        int studentId = Int32.Parse(rdr.GetString(0));
                        string query = "UPDATE student SET priority =" + numPri + " WHERE id =" + studentId + ";";
                        MySqlCommand command2 = new MySqlCommand(query, con2);
                        command2.CommandText = "UPDATE student SET priority =" + numPri + " WHERE id =" + studentId + ";";
                        command2.Parameters.AddWithValue("priority", numPri);
                        command2.Connection = con2;
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Data added");
                    }
                    rdr.Close();
                }
                displayTable(con, id);
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            con2.Close();
        }
        public void displayTable(MySqlConnection c, int id)
        {
            string connectionString = "server=localhost;database=;uid=;pwd=;";
            MySqlConnection con3 = new MySqlConnection(connectionString);
            try
            {
                con3.Open();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string sql = "SELECT * FROM mydatabase.student WHERE priority > 0 AND id != " + id.ToString() + ";";
                MySqlCommand command = new MySqlCommand(sql, con);
                using (MySqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        ListViewItem item = new ListViewItem(rdr[0].ToString());
                        item.SubItems.Add(rdr[1].ToString());
                        item.SubItems.Add(rdr[2].ToString());
                        item.SubItems.Add(rdr[3].ToString());
                        item.SubItems.Add(rdr[4].ToString());
                        item.SubItems.Add(rdr[5].ToString());
                        listView.Items.Add(item);
                    }
                    rdr.Close();
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            con3.Close();
        }
    }
}
