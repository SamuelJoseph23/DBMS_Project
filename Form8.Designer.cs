namespace DBMS_Project
{
    partial class Form8
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
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxPowers = new TextBox();
            textBoxDamage = new TextBox();
            labelName = new Label();
            labelDescription = new Label();
            labelPowers = new Label();
            labelDamage = new Label();
            buttonInsert = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(213, 108);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(670, 108);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 27);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxPowers
            // 
            textBoxPowers.Location = new Point(213, 214);
            textBoxPowers.Name = "textBoxPowers";
            textBoxPowers.Size = new Size(200, 27);
            textBoxPowers.TabIndex = 2;
            // 
            // textBoxDamage
            // 
            textBoxDamage.Location = new Point(670, 214);
            textBoxDamage.Name = "textBoxDamage";
            textBoxDamage.Size = new Size(190, 27);
            textBoxDamage.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(48, 98);
            labelName.Name = "labelName";
            labelName.Size = new Size(137, 48);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            labelName.Click += labelName_Click;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            labelDescription.ForeColor = SystemColors.ButtonHighlight;
            labelDescription.Location = new Point(419, 98);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(250, 48);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Description";
            // 
            // labelPowers
            // 
            labelPowers.AutoSize = true;
            labelPowers.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            labelPowers.ForeColor = SystemColors.ButtonHighlight;
            labelPowers.Location = new Point(16, 202);
            labelPowers.Name = "labelPowers";
            labelPowers.Size = new Size(169, 48);
            labelPowers.TabIndex = 6;
            labelPowers.Text = "Powers";
            // 
            // labelDamage
            // 
            labelDamage.AutoSize = true;
            labelDamage.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            labelDamage.ForeColor = SystemColors.ButtonHighlight;
            labelDamage.Location = new Point(479, 193);
            labelDamage.Name = "labelDamage";
            labelDamage.Size = new Size(185, 48);
            labelDamage.TabIndex = 7;
            labelDamage.Text = "Damage";
            // 
            // buttonInsert
            // 
            buttonInsert.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            buttonInsert.Location = new Point(327, 300);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(228, 53);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 30F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(724, 59);
            label1.TabIndex = 19;
            label1.Text = "Create your own weapon!";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(-2, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 10);
            panel1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(645, 433);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 25;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(872, 504);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(buttonInsert);
            Controls.Add(labelDamage);
            Controls.Add(labelPowers);
            Controls.Add(labelDescription);
            Controls.Add(labelName);
            Controls.Add(textBoxDamage);
            Controls.Add(textBoxPowers);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "Form8";
            Text = "Insert Weapon";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPowers;
        private System.Windows.Forms.TextBox textBoxDamage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPowers;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Button buttonInsert;
        private Label label1;
        private Panel panel1;
        private Button button1;
    }
}

