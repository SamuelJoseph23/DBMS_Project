using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST;DATABASE=norse;UID=root;PASSWORD=SAMUELjoseph_2005;");
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Code to handle form load event
        }

        private void View_Click(object sender, EventArgs e)
        {
            // Code to view data
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Code to handle cell content click event
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Code to handle label click event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code to navigate to page 2
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            string realm = textBoxRealm.Text;
            string domain = textBoxDomain.Text;
            string weapon = textBoxWeapon.Text;
            string hp = textBoxHP.Text;

            if (InsertGod(name, description, realm, domain, weapon, hp))
            {
                MessageBox.Show("God inserted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to insert god.");
            }
        }

        private bool InsertGod(string name, string description, string realm, string domain, string weapon, string hp)
        {
            try
            {
                string query = "INSERT INTO gods (name, description, realm, domain, weapon, hp) VALUES (@name, @description, @realm, @domain, @weapon, @hp)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@realm", realm);
                cmd.Parameters.AddWithValue("@domain", domain);
                cmd.Parameters.AddWithValue("@weapon", weapon);
                cmd.Parameters.AddWithValue("@hp", hp);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void labelHP_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
            this.Close();
        }
    }
}
