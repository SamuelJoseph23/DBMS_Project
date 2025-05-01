namespace DBMS_Project
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Add any initialization code here
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxGods = new ComboBox();
            comboBoxOpponentGods = new ComboBox();
            btnStartBattle = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // comboBoxGods
            // 
            comboBoxGods.BackColor = SystemColors.ControlLightLight;
            comboBoxGods.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxGods.FormattingEnabled = true;
            comboBoxGods.Location = new Point(49, 173);
            comboBoxGods.Name = "comboBoxGods";
            comboBoxGods.Size = new Size(256, 49);
            comboBoxGods.TabIndex = 0;
            comboBoxGods.SelectedIndexChanged += comboBoxGods_SelectedIndexChanged;
            // 
            // comboBoxOpponentGods
            // 
            comboBoxOpponentGods.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxOpponentGods.FormattingEnabled = true;
            comboBoxOpponentGods.Location = new Point(505, 173);
            comboBoxOpponentGods.Name = "comboBoxOpponentGods";
            comboBoxOpponentGods.Size = new Size(320, 49);
            comboBoxOpponentGods.TabIndex = 1;
            comboBoxOpponentGods.SelectedIndexChanged += comboBoxOpponentGods_SelectedIndexChanged_1;
            // 
            // btnStartBattle
            // 
            btnStartBattle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartBattle.Location = new Point(360, 182);
            btnStartBattle.Name = "btnStartBattle";
            btnStartBattle.Size = new Size(105, 36);
            btnStartBattle.TabIndex = 2;
            btnStartBattle.Text = "BATTLE!";
            btnStartBattle.UseVisualStyleBackColor = true;
            btnStartBattle.Click += btnStartBattle_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(49, 118);
            label1.Name = "label1";
            label1.Size = new Size(264, 41);
            label1.TabIndex = 3;
            label1.Text = "Choose your god:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(497, 118);
            label2.Name = "label2";
            label2.Size = new Size(328, 41);
            label2.TabIndex = 4;
            label2.Text = "Choose the opponent:";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(631, 430);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 23;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(316, -8);
            label3.Name = "label3";
            label3.Size = new Size(265, 81);
            label3.TabIndex = 24;
            label3.Text = "BATTLE!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(-5, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 11);
            panel1.TabIndex = 25;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(872, 504);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStartBattle);
            Controls.Add(comboBoxOpponentGods);
            Controls.Add(comboBoxGods);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGods;
        private ComboBox comboBoxOpponentGods;
        private Button btnStartBattle;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Panel panel1;
    }
}