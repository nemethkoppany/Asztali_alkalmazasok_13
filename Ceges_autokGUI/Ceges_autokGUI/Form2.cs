using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceges_autokGUI
{
    public partial class Form2 : Form
    {
        private Dictionary<string, int> nevhezAzon = new Dictionary<string, int>();
        private Dictionary<string, int> autohozAzon = new Dictionary<string, int>();
        public Form2()
        {
            InitializeComponent();
            NevekBetoltese();
            AutokBetoltese();
        }

        private void NevekBetoltese()
        {
            NameComboBox.Items.Clear();
            string query = "SELECT alkalmazottak.nev, alkalmazottak.azon FROM alkalmazottak";

            MySqlConnection conn = DatabaseController.CreateConnection();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NameComboBox.Items.Add(reader["nev"]);
                nevhezAzon[reader["nev"].ToString()!] = (int)reader["azon"];
            }
            DatabaseController.CloseConnection(conn);
            NameComboBox.SelectedIndex = 0;
        }
        private void AutokBetoltese()
        {
            CarComboBox.Items.Clear();
            string query = "SELECT autok.rendszam, autok.azon FROM autok";

            MySqlConnection conn = DatabaseController.CreateConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CarComboBox.Items.Add(reader["rendszam"]);
                autohozAzon[reader["rendszam"].ToString()!] = (int)reader["azon"];
            }

            DatabaseController.CloseConnection(conn);
            CarComboBox.SelectedIndex = 0;
        }

        private void felvetelButton_Click(object sender, EventArgs e)
        {
            int iranyKod;
            if(KihajtasRadioButton.Checked)
            {
                iranyKod = 0;
            }
            else if (BehajtasRadioButton.Checked)
            {
                iranyKod = 1;
            }
            else
            {
                label7.Visible = true;
                return;
            }

            DateTime date = DateDateTimePicker.Value;
            DateTime time = TimeDateTimePicker.Value;
            DateTime datetime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);

            int autoAzon = autohozAzon[CarComboBox.SelectedItem!.ToString()!];
            int alkalmazottAzon = nevhezAzon[NameComboBox.SelectedItem!.ToString()!];

            string query = "INSERT INTO parkolo(datum, autoAzon, alkalmazottAzon, kmAllas, beKiHajtas)" +
                "VALUES(@datum, @autoAzon, @alkalmazottAzon, @kmAllas, @beKiHajtas)";


            MySqlConnection conn = DatabaseController.CreateConnection();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("datum", datetime);
            cmd.Parameters.AddWithValue("autoAzon", autoAzon);
            cmd.Parameters.AddWithValue("alkalmazottAzon", alkalmazottAzon);
            cmd.Parameters.AddWithValue("kmAllas", MilageNumericUpDown.Value);
            cmd.Parameters.AddWithValue("beKiHajtas", iranyKod);
            cmd.ExecuteNonQuery();

            DatabaseController.CloseConnection(conn);
            Close();


        }
    }
}
