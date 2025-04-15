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

namespace clientScheduler
{
    public partial class AppointmentEditor : Form
    {
        public AppointmentEditor()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            monthsView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthsView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
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

        private void monthView(string month)
        {
            Int32 year = DateTime.Now.Year;
            DateTime chosen = new DateTime(year, Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames, month) + 1, 1);
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            label6.Text = month;
            foreach (string day in days)
            {
                dataGridView1.Columns.Add(day, day);
                dataGridView1.Columns[day].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void openMonth(object sender, DataGridViewCellEventArgs e)
        {
            monthView(dataGridView1.SelectedCells[0].Value.ToString() ?? "");
        }

        private void AppointmentEditor_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
