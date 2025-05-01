using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBMS_Project
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=LOCALHOST;DATABASE=norse;UID=root;PASSWORD=SAMUELjoseph_2005;"; // Replace with your actual connection string
            string query = "INSERT INTO weapons (weapon, Description, Powers, Damage) VALUES (@Name, @Description, @Powers, @Damage)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", textBoxName.Text);
                    command.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                    command.Parameters.AddWithValue("@Powers", textBoxPowers.Text);
                    command.Parameters.AddWithValue("@Damage", textBoxDamage.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Weapon inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
