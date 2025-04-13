using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace clientScheduler
{
    public partial class Mainview : Form
    {
        public TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        private string username { get; set; }
        private string lang { get; set; }
        private int userID { get; set; }
        private BindingList<Appointment> MyAppointments { get; set; }
        private MySqlConnection connection { get; set; }

        public Mainview(string username, string lang, int userID)
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            TimeSpan localOffset = localZone.GetUtcOffset(DateTime.Now);
            TimeSpan estOffset = est.GetUtcOffset(DateTime.Now);
            TimeSpan offsetDifference = estOffset - localOffset;
            this.lang = lang;
            this.userID = userID;
            this.username = username;
            this.MyAppointments = new BindingList<Appointment>();
            connection = Program.connect();
            InitializeComponent();
            label2.Text = username;
            getYourAppts(offsetDifference);
            populateAppts();
        }

        private void mainClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void getYourAppts(TimeSpan offset)
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM appointment WHERE userId = {userID}";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Appointment newApp = new Appointment(
                    reader.GetInt32("appointmentId"),
                    reader.GetInt32("customerId"),
                    reader.GetInt32("userId"),
                    reader.GetString("title"),
                    reader.GetString("description"),
                    reader.GetString("contact"),
                    reader.GetString("url"),
                    reader.GetString("type"),
                    reader.GetDateTime("start").Subtract(offset),
                    reader.GetDateTime("start").Subtract(offset),
                    reader.GetDateTime("end").Subtract(offset)
                    );
                MyAppointments.Add(newApp);
            }
            connection.Close();
        }

        private void populateAppts()
        {
            dataGridView1.DataSource = this.MyAppointments;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[8].DefaultCellStyle.Format = "MM/dd/yyyy";
            dataGridView1.Columns[9].DefaultCellStyle.Format = "hh:mm:ss tt";
            dataGridView1.Columns[10].DefaultCellStyle.Format = "hh:mm:ss tt";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Client Editor
            clientEditor clientEditor = new clientEditor();
            clientEditor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open Appointment Editor
            AppointmentEditor appointmentEditor = new AppointmentEditor();
            appointmentEditor.ShowDialog();
        }
    }
}
