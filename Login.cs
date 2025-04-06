using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;

namespace clientScheduler;

public partial class Login : Form
{
    private string lang { get; set; }
    private string locality { get; set; }
    private MySqlConnection connection { get; set; }
    public Login()
    {
        lang = "English (US)";
        locality = RegionInfo.CurrentRegion.ThreeLetterISORegionName.ToString();
        InitializeComponent();

        label1.Text = $"Region: {locality}";
        // Language Controls
        if (System.Globalization.CultureInfo.CurrentCulture.Name == "de")
        {
            lang = "Deutsch (DE)";
            radioButton2.Checked = true;
        }

        connection = Program.connect();

    }

    private void changeLang(string lang)
    {
        if (lang == "en")
        {
            textBox1.Text = "Username";
            textBox2.Text = "Password";
            button1.Text = "Log In";
            label1.Text = $"Region: {locality}";
            label2.Text = "Language (System)";
        }
        else if (lang == "de")
        {
            textBox1.Text = "Benutzername";
            textBox2.Text = "Kennwort";
            button1.Text = "Log sich Ein";
            label1.Text = $"Ort: {locality}";
            label2.Text = "Sprache (System)";
        }
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
        handleLogin(textBox1.Text, textBox2.Text);
    }

    private void handleLogin(string username, string password)
    {
        bool isAuth = false;
        int userID = 0;
        try
        {
            bool isUser = false;
            bool isPass = false;
            connection.Open();
            MySqlCommand checkUser = connection.CreateCommand();
            checkUser.CommandText = $"SELECT * FROM user WHERE userName = \"{username}\";";

            MySqlCommand checkPass = connection.CreateCommand();
            checkPass.CommandText = $"SELECT password FROM user WHERE userName = \"{username}\";";
            MySqlDataReader reader = checkUser.ExecuteReader();
            while (reader.Read())
            {
                isUser = reader.GetString("userName") == username ? true : false;
                userID = reader.GetInt32("userId");

            }
            reader.Close();
            MySqlDataReader reader2 = checkPass.ExecuteReader();
            while (reader2.Read())
            {

                isPass = reader2.GetString("password") == password ? true : false;
            }
            reader2.Close();
            if (!isUser)
            {
                MessageBox.Show("This user doesn't exist.");
            }
            else
            {
                if (!isPass)
                {
                    MessageBox.Show("The password is incorrect.");
                }
            }

            if (isUser && isPass)
            {
                isAuth = true;
            }
            connection.Close();

        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
        if (isAuth)
        {
            this.Hide();
            Program.TriggerMain(username, lang, userID);
        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        changeLang("en");
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        changeLang("de");
    }
}
