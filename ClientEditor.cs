using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;


namespace clientScheduler
{
    public partial class clientEditor : Form
    {
        private MySqlConnection connection { get; set; }
        private BindingList<Person> clients { get; set; }
        public clientEditor()
        {
            connection = Program.connect();
            clients = new BindingList<Person>();
            InitializeComponent();
            populateClients();
        }

        public void populateClients()
        {
            connection.Open();
            MySqlCommand commsie = connection.CreateCommand();
            commsie.CommandText = @"SELECT 
                    c.*,  
                    a.address, 
                    a.cityId, 
                    a.postalCode, 
                    a.phone
                FROM 
                    customer c
                JOIN 
                    address a ON c.addressId = a.addressId;";
            MySqlDataReader readie = commsie.ExecuteReader();
            while (readie.Read())
            {
                clients.Add(new Person(
                    readie.GetInt32("customerId"),
                    readie.GetString("customerName"),
                    readie.GetString("address"),
                    readie.GetInt32("cityId"),
                    readie.GetString("postalCode"),
                    readie.GetString("phone"),
                    readie.GetInt32("active"),
                    readie.GetDateTime("createDate"),
                    readie.GetString("createdBy"),
                    readie.GetDateTime("lastUpdate"),
                    readie.GetString("lastUpdateBy")
                    ));
            }
            connection.Close();
            dataGridView1.DataSource = this.clients;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientEditor_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rowSelected(object sender, EventArgs e)
        {
            // pick a client
            Person thisPerson = dataGridView1.SelectedRows[0].DataBoundItem as Person;
            numericUpDown1.Value = thisPerson.customerId;
            textBox1.Text = thisPerson.customerName;
            textBox2.Text = thisPerson.address;
            numericUpDown2.Value = thisPerson.cityId;
            textBox3.Text = thisPerson.postalCode;
            textBox4.Text = thisPerson.phone;
            numericUpDown3.Value = thisPerson.active;
            populateClientAppointments(thisPerson.customerId);
        }

        private void populateClientAppointments(Int32 id)
        {
            dataGridView2.Rows.Clear();
            BindingList<Appointment> personApps = new BindingList<Appointment>();
            connection.Open();
            MySqlCommand popCommand = connection.CreateCommand();
            popCommand.CommandText = $"SELECT * FROM appointment WHERE customerId = {id}";
            MySqlDataReader popReader = popCommand.ExecuteReader();
            while (popReader.Read())
            {
                personApps.Add(new Appointment(
                        popReader.GetInt32("appointmentId"),
                        popReader.GetInt32("customerId"),
                        popReader.GetInt32("userId"),
                        popReader.GetString("title"),
                        popReader.GetString("description"),
                        popReader.GetString("contact"),
                        popReader.GetString("url"),
                        popReader.GetString("location"),
                        popReader.GetString("type"),
                        popReader.GetDateTime("start").Subtract(Mainview.OffsetDifference),
                        popReader.GetDateTime("start").Subtract(Mainview.OffsetDifference),
                        popReader.GetDateTime("end").Subtract(Mainview.OffsetDifference),
                        popReader.GetDateTime("createDate").Subtract(Mainview.OffsetDifference),
                        popReader.GetString("createdBy"),
                        popReader.GetDateTime("lastUpdate").Subtract(Mainview.OffsetDifference),
                        popReader.GetString("createdBy")
                    ));
            }
            dataGridView2.DataSource = personApps;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoGenerateColumns = true;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person client;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                client = dataGridView1.SelectedRows[0].DataBoundItem as Person;

            } else
            {
                List<Person> sorted = clients.OrderBy(c => c.customerId).ToList();

                // Create a new BindingList based on the sorted list
                BindingList<Person> sortedClientList = new BindingList<Person>(sorted);
                client = new Person();
            }
            // update or create record
            // remember you have to create an address record too
            int thisId = numericUpDown1.Value;
            bool matches = false;
            foreach (Person client in clients)
            {
                if (client.customerId == thisId)
                {
                    matches = true;
                }
            }
            
            if (matches)
            {
                updateClientRecord(client);
            } else
            {
                newClientRecord(client);
            }
        }

        private void updateClientRecord(Person client)
        {

        }

        private void newClientRecord(Person client)
        {

        }
    }
}
