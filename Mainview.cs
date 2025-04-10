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
        private string username { get; set; }
        private string lang { get; set; }
        private int userID { get; set; }
        private BindingList<Appointment> MyAppointments { get; set; }
        private MySqlConnection connection { get; set; }
        public Mainview(string username, string lang, int userID)
        {
            this.lang = lang;
            this.userID = userID;
            this.username = username;
            this.MyAppointments = new BindingList<Appointment>();
            connection = Program.connect();
            InitializeComponent();
            label2.Text = username;
            getYourAppts();
            populateAppts();
        }

        private void mainClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void getYourAppts()
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
                    reader.GetDateTime("start"),
                    reader.GetDateTime("end")
                    );
                MyAppointments.Add(newApp);
            }
            connection.Close();
        }

        private void populateAppts()
        {
            dataGridView1.DataSource = this.MyAppointments;
            dataGridView1.AutoGenerateColumns = true;
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
