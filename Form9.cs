using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBMS_Project
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=LOCALHOST;DATABASE=norse;UID=root;PASSWORD=SAMUELjoseph_2005;"; // Replace with your actual connection string
            string query = "SELECT * FROM weapons WHERE weapon LIKE @Name";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", "%" + textBoxSearch.Text + "%");

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                labelResult.Text = $"Name: {reader["weapon"]}, Description: {reader["Description"]}";
                            }
                            else
                            {
                                labelResult.Text = "No results found.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
