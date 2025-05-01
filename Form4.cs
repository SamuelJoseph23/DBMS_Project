using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer; // Add this line to resolve ambiguity

namespace DBMS_Project
{
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST;DATABASE=norse;UID=root;PASSWORD=SAMUELjoseph_2005;");
        private Timer battleTimer;
        private string? selectedGod; // Make nullable
        private string? opponentGod; // Make nullable
        private ProgressBar progressBar;

        public Form4()
        {
            InitializeComponent();
            PopulateGodsComboBox();
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBoxGods.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOpponentGods.DropDownStyle = ComboBoxStyle.DropDownList;

            // Initialize the Timer
            battleTimer = new Timer();
            battleTimer.Interval = 2000; // 5 seconds
            battleTimer.Tick += BattleTimer_Tick;

            // Initialize the ProgressBar
            progressBar = new ProgressBar();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Visible = false;
            progressBar.Width = 200; // Set the width of the progress bar
            progressBar.Height = 30; // Set the height of the progress bar
            Controls.Add(progressBar);
            PositionProgressBar();
        }

        private void PositionProgressBar()
        {
            // Position the progress bar at the bottom middle of the form
            progressBar.Left = (ClientSize.Width - progressBar.Width) / 2;
            progressBar.Top = ClientSize.Height - progressBar.Height - 10;
        }

        private void Form4_Resize(object? sender, EventArgs e)
        {
            // Reposition the progress bar when the form is resized
            PositionProgressBar();
        }

        private void comboBoxGods_SelectedIndexChanged(object? sender, EventArgs e)
        {
        }

        private void comboBoxOpponentGods_SelectedIndexChanged(object? sender, EventArgs e)
        {
        }

        private void PopulateGodsComboBox()
        {
            try
            {
                string query = "SELECT name FROM gods";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string? godName = reader["name"].ToString();
                    if (godName != null)
                    {
                        comboBoxGods.Items.Add(godName);
                        comboBoxOpponentGods.Items.Add(godName);
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnStartBattle_Click(object? sender, EventArgs e)
        {
            selectedGod = comboBoxGods.SelectedItem?.ToString();
            opponentGod = comboBoxOpponentGods.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedGod) || string.IsNullOrEmpty(opponentGod))
            {
                MessageBox.Show("Please select both gods.");
                return;
            }

            // Show and reset the progress bar
            progressBar.Visible = true;
            progressBar.Value = 0;

            // Start the timer
            battleTimer.Start();
        }

        private void BattleTimer_Tick(object? sender, EventArgs e)
        {
            // Stop the timer
            battleTimer.Stop();

            // Simulate progress
            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                System.Threading.Thread.Sleep(50); // Simulate work being done
            }

            int selectedGodHp = GetGodHp(selectedGod!);
            int opponentGodHp = GetGodHp(opponentGod!);

            if (selectedGodHp > opponentGodHp)
            {
                MessageBox.Show($"{selectedGod} wins with {selectedGodHp} HP against {opponentGod}'s {opponentGodHp} HP!");
            }
            else if (selectedGodHp < opponentGodHp)
            {
                MessageBox.Show($"{opponentGod} wins with {opponentGodHp} HP against {selectedGod}'s {selectedGodHp} HP!");
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }

            // Hide the progress bar
            progressBar.Visible = false;
        }

        private int GetGodHp(string godName)
        {
            try
            {
                string query = "SELECT hp FROM gods WHERE name=@name";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", godName);

                con.Open();
                int hp = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                return hp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }

        private void btnStartBattle_Click_1(object? sender, EventArgs e)
        {
            selectedGod = comboBoxGods.SelectedItem?.ToString();
            opponentGod = comboBoxOpponentGods.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedGod) || string.IsNullOrEmpty(opponentGod))
            {
                MessageBox.Show("Please select both gods.");
                return;
            }

            // Show and reset the progress bar
            progressBar.Visible = true;
            progressBar.Value = 0;

            // Start the timer
            battleTimer.Start();
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

        private void comboBoxOpponentGods_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}