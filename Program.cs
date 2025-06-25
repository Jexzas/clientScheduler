namespace clientScheduler;

using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Text;
using System.Runtime.CompilerServices;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Login());
    }    

    public static void TriggerMain(string username, string lang, int userID)
    {
        DateTime date = DateTime.Now;
        FileStream fs = File.OpenWrite(@"./login.txt");
        String fileString = $"{username} - {date.ToString("M/d/yyyy HH:mm:ss")}";
        using (StreamWriter sw = new StreamWriter(fs))
        {
            long endPoint = fs.Length;
            fs.Seek(endPoint, SeekOrigin.Begin);
            sw.WriteLine(fileString);
        }
        Mainview mainview = new Mainview(username, lang, userID);
        mainview.ShowDialog();
    }

    public static MySqlConnection connect()
    {
        string server = "localhost";
        string database = "client_schedule";
        string user = "sqlUser";
        string password = "Passw0rd!";
        string port = "3306";
        string connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4};", server, port, user, password, database);
        return new MySqlConnection(connectionString);
    }
}