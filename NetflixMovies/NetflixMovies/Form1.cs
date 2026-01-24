using MySql.Data.MySqlClient;

namespace NetflixMovies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kereses_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            MySqlConnection conn = DatabaseController.CreateConnection();
            string query = "SELECT netflix_movies.cím, netflix_movies.rendezo, netflix_movies.ertekeles, nyelvek.nyelv, netflix_movies.hozzaadas_datum " +
                "FROM netflix_movies " +
                "INNER JOIN nyelvek ON netflix_movies.nyelv = nyelvek.azon " +
                "ORDER BY netflix_movies.ertekeles DESC";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                decimal ertekeles = decimal.Parse(reader[2].ToString());
                if(ertekeles >= tol_numericUpDown.Value && ertekeles <= ig_NumericUpDown.Value)
                {
                    dataGridView1.Rows.Add(reader["cím"], reader["rendezo"], reader["ertekeles"], reader["nyelv"], reader["hozzaadas_datum"]);
                }
            }
            DatabaseController.CloseConnection(conn);
        }
    }
}
