using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;


namespace clientScheduler
{
    public partial class clientEditor : Form
    {
        private MySqlConnection connection { get; set; }
        private BindingList<Person> clients { get; set; }
        private string Username { get; set; }
        private int nextNum { get; set; }
        private string lang { get; set; }
        public clientEditor(string username, string lang)
        {
            this.Username = username;
            this.lang = lang;
            connection = Program.connect();
            clients = new BindingList<Person>();
            InitializeComponent();
            populateClients();
            nextNum = getNextNumber();
            numericUpDown1.Value = nextNum;
            if (lang == "de")
            {
                german();
            }
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView1.ClearSelection();
        }

        private void german()
        {
            label1.Text = "Kundeneditor";
            label2.Text = "Kundeninformationen";
            label10.Text = "Termine des Kunden";
            label3.Text = "Kundennummer";
            label4.Text = "Kundenname";
            label5.Text = "Adresse";
            label6.Text = "Stadtnummer";
            label7.Text = "Postleitzahl";
            label8.Text = "Telefonnummer";
            label9.Text = "Aktiv?";
            button1.Text = "Aktualisieren";
            button2.Text = "Löschen";
            button3.Text = "Formular zurücksetzen";
        }
        public int getNextNumber()
        {
            List<Person> sorted = clients.OrderBy(c => c.customerId).ToList();

            // Create a new BindingList based on the sorted list
            BindingList<Person> sortedClientList = new BindingList<Person>(sorted);
            int lastNum = sortedClientList[sortedClientList.Count - 1].customerId;
            return lastNum + 1;
        }
        public void populateClients()
        {
            dataGridView1.Rows.Clear();
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
        {   // TODO: validate form
            bool checkForm()
            {
                // name validate
                bool hasSpecialChars = Regex.IsMatch(textBox1.Text, @"[^a-zA-Z0-9 '-]");
                bool lengthGreater2 = textBox1.Text.Length > 2;
                // address
                bool lengthGreater7 = textBox1.Text.Length > 7;
                bool hasAddChars = Regex.IsMatch(textBox2.Text, @"[^a-zA-Z0-9 .,!?#']");
                // postal
                bool length5 = textBox3.Text.Length == 5;
                bool hasZipChars = Regex.IsMatch(textBox2.Text, @"^\d+$");
                // phone
                bool length78 = textBox4.Text.Length == 7 || textBox4.Text.Length == 8;
                bool hasPhoneChars = Regex.IsMatch(textBox2.Text, @"^[0-9\-]+$");
                List<bool> fieldcheck = [hasSpecialChars, lengthGreater2, lengthGreater7, hasAddChars, length5, hasZipChars, length78, hasPhoneChars];
                foreach (bool field in fieldcheck)
                {
                    if (field == true)
                    {
                        continue;
                    }
                    else
                    {
                        string nameOfTestVariable = nameof(field);
                        switch (nameOfTestVariable)
                        {
                            case "hasSpecialChars":
                                MessageBox.Show("Customer name has invalid characters. Alphabet, hypen, apostrophes only");
                                break;
                            case "lenghtGreater2":
                                MessageBox.Show("Customer name is too short.");
                                break;
                            case "lengthGreater7":
                                MessageBox.Show("Address length is too short.");
                                break;
                            case "hasAddChars":
                                MessageBox.Show("Invalid address characters. Alphanumeric and common punctuation only.");
                                break;
                            case "length5":
                                MessageBox.Show("Zip codes must be five digits, numeric");
                                break;
                            case "hasZipChars":
                                MessageBox.Show("Invalid characters in postal code.");
                                break;
                            case "length78":
                                MessageBox.Show("A phone number can only be seven or eight characters incluing a hyphen.");
                                break;
                            case "hasPhoneChars":
                                MessageBox.Show("Phone number must include numbers only except for hyphen.");
                                break;
                            default:
                                return true;
                        }
                        return false;
                    }
                }
            }
            bool isChecked = checkForm();
            if (isChecked == true)
            {
                Person client;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    client = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                }
                else
                {
                    client = new Person(
                           (int)numericUpDown1.Value,
                           textBox1.Text,
                           textBox2.Text,
                           (int)numericUpDown2.Value,
                           textBox3.Text,
                           textBox4.Text,
                           (int)numericUpDown3.Value,
                           DateTime.Now,
                           Username,
                           DateTime.Now,
                           Username
                        );
                }
                // update or create record
                // remember you have to create an address record too
                int thisId = (int)numericUpDown1.Value;
                bool matches = false;
                foreach (Person cli in clients)
                {
                    if (cli.customerId == thisId)
                    {
                        matches = true;
                    }
                }
                if (matches && client != null)
                {
                    client.customerName = textBox1.Text;
                    client.address = textBox2.Text;
                    client.cityId = (int)numericUpDown2.Value;
                    client.active = (int)numericUpDown3.Value;
                    client.postalCode = textBox3.Text;
                    client.phone = textBox4.Text;
                    updateClientRecord(client);
                }
                else if (!matches && client != null)
                {
                    newClientRecord(client);
                }
            }
        }

        private void updateClientRecord(Person client)
        {
            connection.Open();
            MySqlCommand replaceCommand = connection.CreateCommand();
            replaceCommand.CommandText = $@"
                UPDATE customer SET customerName = '{client.customerName}',active = {client.active},lastUpdate = '{DateTime.Now.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}',lastUpdateBy = '{this.Username}' WHERE customerId = {client.customerId};";
            MySqlCommand addressCommand = connection.CreateCommand();
            addressCommand.CommandText = $@"
                UPDATE address SET address = '{client.address}',postalCode = '{client.postalCode}',phone = '{client.phone}', lastUpdate = '{DateTime.Now.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}',lastUpdateBy = '{this.Username}' WHERE addressId = (SELECT addressId FROM customer WHERE customerId = {client.customerId});";
            try
            {
                replaceCommand.ExecuteNonQuery();
                addressCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Hmm. That didn't work.");
            }
            connection.Close();
            dataGridView1.Rows.Clear();
            populateClients();
        }

        private void newClientRecord(Person client)
        {
            // need last addressId
            connection.Open();
            List<int> ids = new List<int>();
            MySqlCommand getLastAdd = connection.CreateCommand();
            getLastAdd.CommandText = "SELECT addressId FROM address;";
            MySqlDataReader readie = getLastAdd.ExecuteReader();
            while (readie.Read())
            {
                for (int i = 0; i < readie.FieldCount; i++)
                {
                    ids.Add(readie.GetInt32(i));
                }
            }
            ids.Sort((a, b) => b.CompareTo(a));
            int newAddId = ids[0] + 1;
            // create new address
            connection.Close();
            connection.Open();
            MySqlCommand newAdd = connection.CreateCommand();
            newAdd.CommandText = $"INSERT INTO address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({newAddId}, '{client.address}', ' ', {client.cityId}, '{client.postalCode}', '{client.phone}', '{DateTime.Now.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}', '{this.Username}', '{DateTime.Now.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}', '{this.Username}');";
            MySqlCommand newClient = connection.CreateCommand();
            newClient.CommandText = $"INSERT INTO customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ({client.customerId}, '{client.customerName}', {newAddId}, '{client.active}', '{DateTime.Now.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}', '{this.Username}', '{DateTime.Now.Add(Mainview.OffsetDifference).ToString("yyyy-MM-dd HH:mm:ss")}', '{this.Username}');";
            try
            {
                newAdd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("That did not work (address)." + ex.Message);
            }
            try
            {
                newClient.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("That did not work(client)." + ex.Message);
            }
            connection.Close();
            populateClients();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // reset form
            numericUpDown1.Value = nextNum;
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown2.Value = 0;
            textBox3.Text = "";
            textBox4.Text = "";
            numericUpDown3.Value = 0;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shortcutApt(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Close this window and jump to the appointment
            this.Hide();
            Appointment selectedApt = dataGridView2.SelectedRows[0].DataBoundItem as Appointment;
            AppointmentEditor appointmentEditor = new AppointmentEditor(this.Username, this.lang);
            appointmentEditor.selectedFromClient(selectedApt);
            appointmentEditor.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete a record
            int id = (int)numericUpDown1.Value;
            connection.Open();
            MySqlCommand delAppsCommand = connection.CreateCommand();
            delAppsCommand.CommandText = $"DELETE FROM appointment WHERE customerId = {id}";
            MySqlCommand delAddCommand = connection.CreateCommand();
            delAddCommand.CommandText = $"DELETE FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = {id});";
            MySqlCommand delCustCommand = connection.CreateCommand();
            delCustCommand.CommandText = $"DELETE FROM customer WHERE customerId = {id}";
            try
            {
                delAppsCommand.ExecuteNonQuery();
                delCustCommand.ExecuteNonQuery();
                delAddCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            dataGridView1.Rows.Clear();
            populateClients();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
