using System;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to handle form load event
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRealm.SelectedItem == null)
                {
                    throw new InvalidOperationException("Please select a realm from the dropdown.");
                }

                string selectedRealm = comboBoxRealm.SelectedItem.ToString();
                string details = GetRealmDetails(selectedRealm);
                MessageBox.Show(details, "Realm Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string GetRealmDetails(string realm)
        {
            switch (realm)
            {
                case "Asgard":
                    return "Name: Asgard\nDescription: Realm of the Aesir gods\nRulers: Odin\nDwellers: Aesir gods";
                case "Midgard":
                    return "Name: Midgard\nDescription: Realm of humans\nRulers: None\nDwellers: Humans";
                case "Jotunheim":
                    return "Name: Jotunheim\nDescription: Realm of the giants\nRulers: None\nDwellers: Giants";
                case "Vanaheim":
                    return "Name: Vanaheim\nDescription: Realm of the Vanir gods\nRulers: Njord\nDwellers: Vanir gods";
                case "Alfheim":
                    return "Name: Alfheim\nDescription: Realm of the light elves\nRulers: Freyr\nDwellers: Light elves";
                case "Svartalfheim":
                    return "Name: Svartalfheim\nDescription: Realm of the dark elves\nRulers: None\nDwellers: Dark elves";
                case "Niflheim":
                    return "Name: Niflheim\nDescription: Realm of ice and mist\nRulers: None\nDwellers: None";
                case "Muspelheim":
                    return "Name: Muspelheim\nDescription: Realm of fire\nRulers: Surtr\nDwellers: Fire giants";
                case "Helheim":
                    return "Name: Helheim\nDescription: Realm of the dead\nRulers: Hel\nDwellers: Dead souls";
                default:
                    return "Unknown realm";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
            this.Close();
        }

        private void comboBoxRealm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
