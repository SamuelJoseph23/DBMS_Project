namespace DBMS_Project
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxWeapons = new ComboBox();
            buttonShowDetails = new Button();
            labelDetails = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxWeapons
            // 
            comboBoxWeapons.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxWeapons.FormattingEnabled = true;
            comboBoxWeapons.Location = new Point(365, 100);
            comboBoxWeapons.Name = "comboBoxWeapons";
            comboBoxWeapons.Size = new Size(200, 48);
            comboBoxWeapons.TabIndex = 0;
            // 
            // buttonShowDetails
            // 
            buttonShowDetails.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowDetails.Location = new Point(630, 101);
            buttonShowDetails.Name = "buttonShowDetails";
            buttonShowDetails.Size = new Size(211, 48);
            buttonShowDetails.TabIndex = 1;
            buttonShowDetails.Text = "Show Details";
            buttonShowDetails.UseVisualStyleBackColor = true;
            buttonShowDetails.Click += buttonShowDetails_Click;
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Location = new Point(100, 100);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(0, 20);
            labelDetails.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(251, 9);
            label1.Name = "label1";
            label1.Size = new Size(467, 71);
            label1.TabIndex = 3;
            label1.Text = "WEAPON-PEDIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(347, 45);
            label2.TabIndex = 4;
            label2.Text = "Choose a weapon";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(-1, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 10);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(666, 444);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 24;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(872, 504);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelDetails);
            Controls.Add(buttonShowDetails);
            Controls.Add(comboBoxWeapons);
            ForeColor = SystemColors.ControlText;
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxWeapons;
        private System.Windows.Forms.Button buttonShowDetails;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Panel panel1;
        private Button button1;
    }
}




