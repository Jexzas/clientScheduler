﻿using System;
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
        public string Username;
        private string lang { get; set; }
        private int userID { get; set; }
        private BindingList<Appointment> MyAppointments { get; set; }
        private MySqlConnection connection { get; set; }
        public static TimeSpan OffsetDifference;

        public Mainview(string username, string lang, int userID)
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            TimeSpan localOffset = localZone.GetUtcOffset(DateTime.Now);
            TimeSpan estOffset = est.GetUtcOffset(DateTime.Now);
            OffsetDifference = estOffset - localOffset;
            this.lang = lang;
            this.userID = userID;
            this.Username = username;
            this.MyAppointments = new BindingList<Appointment>();
            connection = Program.connect();
            InitializeComponent();
            label2.Text = Username;
            getYourAppts(OffsetDifference);
            populateAppts();
            if (this.lang == "de")
            {
                label3.Text = "Terminplanung mit Kunden";
                label1.Text = "Wilkommen";
                button1.Text = "Kunden Verwalten";
                button2.Text = "Termine Verwalten";
            }
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
                    reader.GetString("location"),
                    reader.GetString("type"),
                    reader.GetDateTime("start").Subtract(offset),
                    reader.GetDateTime("start").Subtract(offset),
                    reader.GetDateTime("end").Subtract(offset),
                    reader.GetDateTime("createDate").Subtract(offset),
                    reader.GetString("createdBy"),
                    reader.GetDateTime("lastUpdate").Subtract(offset),
                    reader.GetString("createdBy")
                    );
                MyAppointments.Add(newApp);
            }
            connection.Close();
        }

        private void populateAppts()
        {
            dataGridView1.DataSource = this.MyAppointments;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[9].DefaultCellStyle.Format = "MM/dd/yyyy";
            dataGridView1.Columns[10].DefaultCellStyle.Format = "hh:mm:ss tt";
            dataGridView1.Columns[11].DefaultCellStyle.Format = "hh:mm:ss tt";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Client Editor
            clientEditor clientEditor = new clientEditor(this.Username, this.lang);
            clientEditor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open Appointment Editor
            AppointmentEditor appointmentEditor = new AppointmentEditor(this.Username, this.lang);
            appointmentEditor.ShowDialog();
        }
    }
}
