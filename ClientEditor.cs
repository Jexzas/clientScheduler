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
    }
}
