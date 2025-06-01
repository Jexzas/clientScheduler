using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace clientScheduler
{
    public partial class AppointmentEditor : Form
    {
        string username { get; set; }
        string lang {  get; set; }
        public AppointmentEditor(string username, string lang)
        {
            InitializeComponent();
            numericUpDown3.Maximum = GetUser();
            this.username = username;
            this.lang = lang;
            label9.Text = DateTime.Now.Year.ToString();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            monthsView(DateTime.Now.Year.ToString());
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker4.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            clearFields();
            if (this.lang == "de")
            {
                label1.Text = "Termine Verwalten";
                button1.Text = "Zurück";
                label3.Text = "Kalendersicht";
                label7.Text = "Jahr";
                label5.Text = "Monat";
                label2.Text = "Verfügbare Termine";
                label4.Text = "Termindetails";
                button6.Text = "Termin Löschen";
                button5.Text = "Eintrag erstellen oder bearbeiten";
                label10.Text = "Termin ID";
                label11.Text = "Kunde ID";
                label12.Text = "Benutzer ID";
                button4.Text = "Felder Löschen";
                label13.Text = "Titel";
                label14.Text = "Beschreibung";
                label14.Text = "Ort";
                label16.Text = "Kontakt";
                label17.Text = "Typ";
                label19.Text = "Startdatum/-zeit";
                label20.Text = "Enddatum/-zeit";
                label21.Text = "Anlagedatum";
                label22.Text = "Erstellt von";
                label23.Text = "Letztes Änderungsdatum/-zeit";
                label24.Text = "Zuletzt aktualisiert von";
            }
        }

        public static int GetUser()
        {
            MySqlConnection thisConnect = Program.connect();
            thisConnect.Open();
            MySqlCommand thisCommand = thisConnect.CreateCommand();
            thisCommand.CommandText = "SELECT max(userId) FROM user;";
            MySqlDataReader reader = thisCommand.ExecuteReader();
            int maxUser = 1;
            while (reader.Read())
            {
                maxUser = reader.GetInt32("max(userId)");
            }
            thisConnect.Close();
            return maxUser;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthsView(string year = "2025")
        {
            button1.Visible = false;
            label9.Text = year;
            dataGridView3.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < 3; i++)
            {
                var col = new DataGridViewTextBoxColumn();
                col.Name = "col" + i;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(col);
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Fill 4 rows (12 months / 3 columns = 4 rows)
            string[] months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            int monthIndex = 0;

            for (int row = 0; row < 4; row++)
            {
                dataGridView1.Rows.Add();
                for (int col = 0; col < 3; col++)
                {
                    if (monthIndex < 12)
                    {
                        dataGridView1.Rows[row].Cells[col].Value = months[monthIndex];
                        monthIndex++;
                    }
                }
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 105;
            }
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void monthView(string month, string year)
        {
            button1.Visible = true;
            dataGridView3.Visible = true;
            dataGridView1.Visible = false;
            Int32 chosenYear = Int32.Parse(year);
            DateTime chosen = new DateTime(chosenYear, Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames, month) + 1, 1);
            string[] days = new string[7];
            if (lang == "en")
            {
                days = [ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" ];
            } else if (lang == "de")
            {
                days = [ "Sonn", "Mon", "Dien", "Mitt", "Donn", "Frei", "Sams" ];
            }
                dataGridView3.DataSource = null;
            dataGridView3.Columns.Clear();
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.Rows.Clear();
            label6.Text = month;
            foreach (string day in days)
            {
                dataGridView3.Columns.Add(day, day);
            }
            int counter = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = days[counter];
                counter++;
            }
            int startDay = (Int32)chosen.DayOfWeek;
            int daysOfMonth = DateTime.DaysInMonth(chosen.Year, chosen.Month);

            dataGridView3.ColumnHeadersVisible = true;
            dataGridView3.RowHeadersVisible = false;
            List<string> week = new List<string>();
            List<string[]> weeks = new List<string[]>();


            for (int i = 0; i < startDay; i++)
            {
                week.Add("");
            }
            for (int day = 1; day <= daysOfMonth; day++)
            {
                week.Add(day.ToString());

                if (week.Count == 7)
                {
                    weeks.Add(week.ToArray<string>());
                    week.Clear();
                }
                if (day == daysOfMonth && week.Count < 7)
                {
                    for (int p = 0; p < 7 - week.Count; p++)
                    {
                        week.Add(" ");
                    }
                    weeks.Add(week.ToArray<string>());
                }
            }

            foreach (string[] weeko in weeks)
            {
                dataGridView3.Rows.Add(weeko);
            }
            dataGridView3.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ReadOnly = true;
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                row.Height = 70;
            }
        }

        private void openMonth(object sender, DataGridViewCellEventArgs e)
        {
            monthView(dataGridView1.SelectedCells[0].Value.ToString() ?? "", label9.Text);
        }

        private void AppointmentEditor_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDay(sender, e);
        }

        private void clickDay(object sender, DataGridViewCellEventArgs e)
        {
            DateTime againChosen = new DateTime(Int32.Parse(label9.Text), Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames, dataGridView1.SelectedCells[0].Value.ToString()) + 1, 1);
            showDay(dataGridView3.SelectedCells[0].Value.ToString() ?? "", againChosen);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthsView();
        }

        private void showDay(string day, DateTime month)
        {
            MySqlConnection thisConnect = Program.connect();
            BindingList<Appointment> availableAppointments = new BindingList<Appointment>();
            dataGridView2.Rows.Clear();
            if (day != "")
            {
                thisConnect.Open();
                MySqlCommand command = thisConnect.CreateCommand();
                command.CommandText = $"SELECT * FROM appointment WHERE CAST(start AS DATE) = '{month.Year}-{month.Month}-{day}';";
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
                        reader.GetDateTime("start").Subtract(Mainview.OffsetDifference),
                        reader.GetDateTime("start").Subtract(Mainview.OffsetDifference),
                        reader.GetDateTime("end").Subtract(Mainview.OffsetDifference),
                        reader.GetDateTime("createDate").Subtract(Mainview.OffsetDifference),
                        reader.GetString("createdBy"),
                        reader.GetDateTime("lastUpdate").Subtract(Mainview.OffsetDifference),
                        reader.GetString("createdBy")
                    );
                    availableAppointments.Add(newApp);
                }
                thisConnect.Close();
            }
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DataSource = availableAppointments;
            if (dataGridView2.SelectedRows.Count > 0) dataGridView2.SelectedRows[0].Selected = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // forward a year
            monthsView((Int32.Parse(label9.Text) + 1).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // back a year
            monthsView((Int32.Parse(label9.Text) - 1).ToString());

        }

        private void rowSelected(object sender, EventArgs e)
        {
            Appointment thisAppointment = dataGridView2.SelectedRows[0].DataBoundItem as Appointment;
            numericUpDown1.Value = thisAppointment.appID;
            numericUpDown2.Value = thisAppointment.customerID;
            numericUpDown3.Value = thisAppointment.userId;
            textBox1.Text = thisAppointment.title;
            textBox2.Text = thisAppointment.description;
            textBox3.Text = thisAppointment.location;
            textBox4.Text = thisAppointment.contact;
            textBox5.Text = thisAppointment.type;
            textBox6.Text = thisAppointment.url;
            dateTimePicker1.Value = thisAppointment.start;
            dateTimePicker2.Value = thisAppointment.end;
            dateTimePicker3.Value = thisAppointment.createDate;
            textBox7.Text = thisAppointment.createdBy;
            textBox8.Text = thisAppointment.updatedBy;
            dateTimePicker4.Value = thisAppointment.lastUpdate;

        }

        private void label21_Click(object sender, EventArgs e)
        {
            // do nothing
        }

        private void label22_Click(object sender, EventArgs e)
        {
            // do nothing
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearFields();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            // create or update 
            // check for existing appointment
            textBox8.Text = this.username;
            MySqlConnection thisConnect = Program.connect();
            thisConnect.Open();
            string method = "new"; // new or edit
            Int32 testCase = (Int32)numericUpDown1.Value;
            MySqlCommand tryCommand = thisConnect.CreateCommand();
            tryCommand.CommandText = $"SELECT appointmentId FROM appointment WHERE appointmentId = {testCase}";
            MySqlDataReader reader = tryCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) == testCase)
                {
                    method = "edit";
                }
                else
                {
                    method = "new";
                }

            }
            thisConnect.Close();
            thisConnect.Open();
            Appointment newAppointment = new Appointment(
                    testCase,
                    (int)numericUpDown2.Value,
                    (int)numericUpDown3.Value,
                    textBox1.Text,
                    textBox2.Text,
                    textBox4.Text,
                    textBox6.Text,
                    textBox3.Text,
                    textBox5.Text,
                    dateTimePicker1.Value.Date,
                    dateTimePicker1.Value,
                    dateTimePicker2.Value,
                    DateTime.Now,
                    textBox7.Text,
                    DateTime.Now,
                    textBox8.Text
                    );
            MySqlCommand newEntry = thisConnect.CreateCommand();

            if (method == "new")
            {
                newAppointment.createdBy = this.username;
                newEntry.CommandText = $"INSERT INTO appointment (appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({newAppointment.appID}, {newAppointment.customerID}, {newAppointment.userId}, \'{newAppointment.title}\', \'{newAppointment.description}\', \'{newAppointment.location}\', \'{newAppointment.contact}\', \'{newAppointment.type}\', \'{newAppointment.url}\', \'{newAppointment.start.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.end.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.createDate.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.createdBy}\', \'{newAppointment.lastUpdate.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.updatedBy}\')";
            }
            else if (method == "edit")
            {
                newAppointment.createDate = dateTimePicker3.Value;
                newEntry.CommandText = $"DELETE FROM appointment WHERE appointmentId = {testCase}; INSERT INTO appointment (appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({newAppointment.appID}, {newAppointment.customerID}, {newAppointment.userId}, \'{newAppointment.title}\', \'{newAppointment.description}\', \'{newAppointment.location}\', \'{newAppointment.contact}\', \'{newAppointment.type}\', \'{newAppointment.url}\', \'{newAppointment.start.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.end.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.createDate.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.createdBy}\', \'{newAppointment.lastUpdate.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}\', \'{newAppointment.updatedBy}\')";
            }
            else
            {
                MessageBox.Show("Something went wrong. Appointment not created or altered.");
            }

            newEntry.ExecuteNonQuery();
            thisConnect.Close();
        }

        private void clearFields()
        {
            // clear fields
            // increment the appointment id 
            if (dataGridView2.SelectedRows.Count > 0) { dataGridView2.SelectedRows[0].Selected = false; }
            ;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            textBox7.Text = "";
            textBox8.Text = "";
            dateTimePicker4.Value = DateTime.Now;
            MySqlConnection thisConnect = Program.connect();
            thisConnect.Open();
            MySqlCommand command = thisConnect.CreateCommand();
            command.CommandText = "SELECT max(appointmentId) FROM appointment";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                numericUpDown1.Value = reader.GetInt32(0) + 1;
            }
            thisConnect.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Delete appointment
            int chosenId = -1;
            MySqlConnection thisConnect = Program.connect();
            BindingList<Appointment> availableAppointments = new BindingList<Appointment>();
            dataGridView2.Rows.Clear();

            thisConnect.Open();
            MySqlCommand command = thisConnect.CreateCommand();
            command.CommandText = $"SELECT * FROM appointment WHERE appointmentId = {numericUpDown1.Value};";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    chosenId = reader.GetInt32("appointmentId");
                }
                catch (Exception)
                {
                    MessageBox.Show("That is not a real appointment");
                }
            }
            thisConnect.Close();
            if (chosenId >= 0)
            {
                DialogResult confirmResult = this.lang == "de" ? MessageBox.Show("Sind Sie sicher, dass Sie diesen Termin löschen möchten?", "Beseitigung!", MessageBoxButtons.YesNo) : MessageBox.Show("Are you sure you want to delete this appointment?", "Deletion!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) {
                    // delete 
                    MySqlConnection deleteConnect = Program.connect();
                    deleteConnect.Open();
                    MySqlCommand deleteCommand = deleteConnect.CreateCommand();
                    deleteCommand.CommandText = $"DELETE FROM appointment WHERE appointmentId = {numericUpDown1.Value}";
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        if (lang == "de")
                        {
                            MessageBox.Show("Termin gelöscht.");
                        }
                        else
                        {
                            MessageBox.Show("Appointment deleted.");
                        }
                    } catch (Exception)
                    {
                        if (lang == "de")
                        {
                            MessageBox.Show("Warnung: Termin nicht gelöscht.");
                        }
                        else
                        {
                            MessageBox.Show("Issue. Not deleted.");
                        }
                    }
                    
                }

            } else
            {
                if (lang == "de") 
                {
                    MessageBox.Show("Nicht gelöscht.");
                } else
                { MessageBox.Show("Not deleted.");
                };
            }
        }
    }
}
