namespace DBMS_Project
{
    partial class Form5
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
            comboBoxGods = new ComboBox();
            buttonShowDetails = new Button();
            labelDetails = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxGods
            // 
            comboBoxGods.Font = new Font("Segoe UI", 28F);
            comboBoxGods.FormattingEnabled = true;
            comboBoxGods.Location = new Point(359, 125);
            comboBoxGods.Name = "comboBoxGods";
            comboBoxGods.Size = new Size(200, 70);
            comboBoxGods.TabIndex = 0;
            // 
            // buttonShowDetails
            // 
            buttonShowDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowDetails.Location = new Point(610, 127);
            buttonShowDetails.Name = "buttonShowDetails";
            buttonShowDetails.Size = new Size(250, 56);
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
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(551, 71);
            label1.TabIndex = 3;
            label1.Text = "Norse god-pedia";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 28F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(22, 125);
            label2.Name = "label2";
            label2.Size = new Size(313, 56);
            label2.TabIndex = 4;
            label2.Text = "Select god:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(2, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 10);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(655, 432);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 23;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
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
            Controls.Add(comboBoxGods);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxGods;
        private System.Windows.Forms.Button buttonShowDetails;
        private System.Windows.Forms.Label labelDetails;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
    }
}


