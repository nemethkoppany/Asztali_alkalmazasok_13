using MySql.Data.MySqlClient;

namespace RealEstateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSellerNames();
        }
        private void LoadSellerNames()
        {
            MySqlConnection conn = DatabaseController.CreatConnection();
            string query = "SELECT name FROM sellers";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SellerNamesListBox.Items.Add(reader["name"]);

            }
            DatabaseController.CloseConnection(conn);

        }

        private void SellerNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? nev = SellerNamesListBox.SelectedItem.ToString();
            eladoNeveCimke.Text = nev;

            MySqlConnection conn = DatabaseController.CreatConnection();
            string query = "CALL elado_telefonszama(@name)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", nev);
            eladoTelefonszamaCimke.Text = cmd.ExecuteScalar().ToString();
            DatabaseController.CloseConnection(conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(SellerNamesListBox.SelectedItem == null)
            {
                return;
            }
            string? nev = SellerNamesListBox.SelectedItem.ToString();
            MySqlConnection conn = DatabaseController.CreatConnection();
            string query = "CALL hirdetesek_szama(@name)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", nev);
            HirdetesekSzamaCimke.Text = cmd.ExecuteScalar().ToString();
            DatabaseController.CloseConnection(conn);
        }
    }
}


//(Ezeke a XAMPP-os felületbe kellenek)
//14. feladat
//CREATE OR REPLACE PROCEDURE elado_telefonszama(nev VARCHAR(50)) SELECT phone FROM sellers WHERE name = nev;

//15.feladat
//CREATE OR REPLACE PROCEDURE hirdetesek_szama(nev VARCHAR(50)) SELECT COUNT(*) FROM sellers INNER JOIN realestates ON sellers.id = realestates.sellerId WHERE sellers.name = nev;