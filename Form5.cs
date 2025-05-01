using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST;DATABASE=norse;UID=root;PASSWORD=SAMUELjoseph_2005;");

        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadGods();
        }

        private void LoadGods()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT name FROM gods", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxGods.Items.Add(reader.GetString("name"));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGods.SelectedItem == null)
                {
                    throw new InvalidOperationException("Please select a god from the dropdown.");
                }

                string selectedGod = comboBoxGods.SelectedItem?.ToString();
                string details = GetGodDetails(selectedGod);
                MessageBox.Show(details, "God Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetGodDetails(string godName)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT g.name, g.realm, w.weapon FROM gods g LEFT JOIN weapons w ON g.weapon = w.weapon WHERE g.name = @godName", con);
                cmd.Parameters.AddWithValue("@godName", godName);
                MySqlDataReader reader = cmd.ExecuteReader();

                string details = "";
                if (reader.Read())
                {
                    details = $"Name: {reader["name"]}\n";
                    details += $"Realm: {reader["realm"]}\n";
                    details += $"Weapon: {reader["weapon"]}\n";
                }
                con.Close();

                return details;
            }
            catch (Exception ex)
            {
                con.Close();
                return "Error: " + ex.Message;
            }
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
    }
}


