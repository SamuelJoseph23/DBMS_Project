using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class Form6 : Form
    {
        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST;DATABASE=norse;UID=root;PASSWORD=SAMUELjoseph_2005;");

        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadWeapons();
        }

        private void LoadWeapons()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT weapon FROM weapons", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxWeapons.Items.Add(reader.GetString("weapon"));
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
                if (comboBoxWeapons.SelectedItem == null)
                {
                    throw new InvalidOperationException("Please select a weapon from the dropdown.");
                }

                string selectedWeapon = comboBoxWeapons.SelectedItem?.ToString();
                string details = GetWeaponDetails(selectedWeapon);
                MessageBox.Show(details, "Weapon Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string GetWeaponDetails(string weaponName)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT weapon, description, powers, damage FROM weapons WHERE weapon = @weaponName", con);
                cmd.Parameters.AddWithValue("@weaponName", weaponName);
                MySqlDataReader reader = cmd.ExecuteReader();

                string details = "";
                if (reader.Read())
                {
                    details = $"Weapon: {reader["weapon"]}\n";
                    details += $"Description: {reader["description"]}\n";
                    details += $"Powers: {reader["powers"]}\n";
                    details += $"Damage: {reader["damage"]}\n";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
            this.Close();
        }
    }
}




