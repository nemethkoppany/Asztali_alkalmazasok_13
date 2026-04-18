using MySql.Data.MySqlClient;

namespace Ceges_autokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadEmployeeNames();
        }

        private void LoadEmployeeNames()
        {
            MySqlConnection conn = DatabaseController.CreateConnection();
            string query = "SELECT nev from alkalmazottak";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["nev"]);
            }
            DatabaseController.CloseConnection(conn);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BerlesekBetoltese();
        }

        private void BerlesekBetoltese()
        {
            dataGridView1.Rows.Clear();
            string nev = listBox1.SelectedItem!.ToString()!;
            string query = "SELECT parkolo.datum, autok.rendszam, autok.tipus, parkolo.kmAllas, parkolo.beKiHajtas " +
                "FROM autok " +
                "INNER JOIN parkolo ON autok.azon = parkolo.autoAzon " +
                "INNER JOIN alkalmazottak ON parkolo.alkalmazottAzon = alkalmazottak.azon " +
                "WHERE alkalmazottak.nev = @nev;";

            MySqlConnection conn = DatabaseController.CreateConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("nev", nev);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string irany = ((int)reader["beKiHajtas"] == 0) ? "ki" : "be";
                dataGridView1.Rows.Add(
                    reader["datum"], reader["rendszam"], reader["tipus"], reader["kmAllas"], irany);
            }
            if (dataGridView1.Rows.Count > 1)
            {
                label1.Text = nev + " bérlései: ";
            }
            else
            {
                label1.Text = nev + " még nem bérelt autót";
            }
            DatabaseController.CloseConnection(conn);
        }

        private void ujBerlesButton_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            if(listBox1.SelectedIndex != -1)
            {
                BerlesekBetoltese();
            }
        }
    }
}
