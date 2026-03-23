using MySql.Data.MySqlClient;
using RealEstateGUI;

namespace SportClubGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadMemberNames();
        }

        private void loadMemberNames()
        {
            MySqlConnection conn = DatabaseController.CreateConnection();
            string query = "SELECT name from members";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["name"]);
            }
            DatabaseController.CloseConnection(conn);
        }

        private void MemberNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nev = listBox1.SelectedItem.ToString();
            tagNeve_Cimke.Text = nev;


            MySqlConnection conn = DatabaseController.CreateConnection();
            string query = "CALL tag_telefonszama(@name)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", nev);
            telefonszamCimke.Text = cmd.ExecuteScalar().ToString();
            DatabaseController.CloseConnection(conn);
        }

        private void edzesekSzama_Button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            string nev = listBox1.SelectedItem.ToString();
            MySqlConnection conn = DatabaseController.CreateConnection();
            string query = "CALL edzesek_szama(@name)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", nev);
            edzesekSzamaCimke.Text = cmd.ExecuteScalar().ToString();
            DatabaseController.CloseConnection(conn);
        }

        private void legutobbiEdzesTipusaButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null)
            {
                return;
            }

            string nev = listBox1.SelectedItem.ToString() ;
            MySqlConnection conn = DatabaseController.CreateConnection();
            string query = "CALL legutobbi_edzes_tipusa(@name)";
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@name", nev);
            legutobbiEdzesTipusaCimke.Text = cmd.ExecuteScalar().ToString();
            DatabaseController.CloseConnection(conn);
        }
    }
}
