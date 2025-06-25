using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientScheduler
{ 
    public partial class Reports : Form
    {
        private int userId { get; set; }
        private string lang { get; set; }
        private BindingList<Appointment> Appointments { get; set; }
        public Reports(BindingList<Appointment> appointments, int userId, string lang)
        {
            InitializeComponent();
            Appointments = appointments;
            this.userId = userId;
            this.lang = lang;
            if (lang == "de")
            {
                button1.Text = 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // generate appointment types grouped by month
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            List<object> report = new (
                Appointments
                    .GroupBy(a => new { a.start.Year, a.start.Month, a.type })
                    .Select(g => new
                    {
                        Month = $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month)} {g.Key.Year}",
                        Type = g.Key.type,
                        Count = g.Count()
                    })
                    .ToList()
            );
            dataGridView1.DataSource = report;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Refresh();
            if (lang == "de")
            {
                dataGridView1.Columns["Month"].HeaderText = "Monat";
                dataGridView1.Columns["Type"].HeaderText = "Typ";
                dataGridView1.Columns["Count"].HeaderText = "Zählung";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // generate appointments (future) per user
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            List<object> report = new (
                Appointments
                    .Where(a => a.start > DateTime.Now)        
                    .OrderBy(a => a.userId)
                    .ThenBy(a => a.start)
                    .Select(a => new
                        {
                            UserId = a.userId,
                            Customer = a.customerID,
                            Title = a.title,
                            Type = a.type,
                            Start = a.start,
                            End = a.end
                        })
                    .ToList()
            );
            if (report.Count == 0)
            {
                MessageBox.Show("No future appointments in database.");
            }
            dataGridView1.DataSource = report;s
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Refresh();
            if (lang == "de")
            {
                dataGridView1.Columns["UserId"].HeaderText = "BenutzerID";
                dataGridView1.Columns["Customer"].HeaderText = "KundeID";
                dataGridView1.Columns["Title"].HeaderText = "Titel";
                dataGridView1.Columns["Type"].HeaderText = "Typ";
                dataGridView1.Columns["Title"].HeaderText = "Titel";
                dataGridView1.Columns["Title"].HeaderText = "Anfang";
                dataGridView1.Columns["Title"].HeaderText = "Ende";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show last 30 days appointments per user
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            List<Appointment> report = new (
                Appointments
                    .Where(a => a.start >= DateTime.Now.AddDays(-30) && a.start <= DateTime.Now && a.userId == this.userId)
                    .ToList()
            );
            if (report.Count == 0)
            {
                MessageBox.Show("No appointments for this user in the last 30 days.");
            }
            dataGridView1.DataSource = report;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Refresh();
        }
    }
}
