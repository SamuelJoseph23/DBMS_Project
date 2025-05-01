namespace DBMS_Project
{
    partial class Form2
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
            textBoxRealm = new TextBox();
            textBoxDomain = new TextBox();
            textBoxWeapon = new TextBox();
            textBoxHP = new TextBox();
            labelName = new Label();
            labelDescription = new Label();
            labelRealm = new Label();
            labelDomain = new Label();
            labelWeapon = new Label();
            labelHP = new Label();
            buttonInsert = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(160, 137);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 34);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 12F);
            textBoxDescription.Location = new Point(643, 137);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 34);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxRealm
            // 
            textBoxRealm.Font = new Font("Segoe UI", 12F);
            textBoxRealm.Location = new Point(160, 233);
            textBoxRealm.Name = "textBoxRealm";
            textBoxRealm.Size = new Size(200, 34);
            textBoxRealm.TabIndex = 7;
            // 
            // textBoxDomain
            // 
            textBoxDomain.Font = new Font("Segoe UI", 12F);
            textBoxDomain.Location = new Point(643, 233);
            textBoxDomain.Name = "textBoxDomain";
            textBoxDomain.Size = new Size(200, 34);
            textBoxDomain.TabIndex = 8;
            // 
            // textBoxWeapon
            // 
            textBoxWeapon.Font = new Font("Segoe UI", 12F);
            textBoxWeapon.Location = new Point(160, 332);
            textBoxWeapon.Name = "textBoxWeapon";
            textBoxWeapon.Size = new Size(200, 34);
            textBoxWeapon.TabIndex = 9;
            // 
            // textBoxHP
            // 
            textBoxHP.Font = new Font("Segoe UI", 12F);
            textBoxHP.Location = new Point(643, 325);
            textBoxHP.Name = "textBoxHP";
            textBoxHP.Size = new Size(200, 34);
            textBoxHP.TabIndex = 10;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonFace;
            labelName.Location = new Point(12, 130);
            labelName.Name = "labelName";
            labelName.Size = new Size(109, 41);
            labelName.TabIndex = 11;
            labelName.Text = "Name:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelDescription.ForeColor = SystemColors.ButtonFace;
            labelDescription.Location = new Point(449, 130);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(188, 41);
            labelDescription.TabIndex = 12;
            labelDescription.Text = "Description:";
            // 
            // labelRealm
            // 
            labelRealm.AutoSize = true;
            labelRealm.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelRealm.ForeColor = SystemColors.ButtonFace;
            labelRealm.Location = new Point(12, 226);
            labelRealm.Name = "labelRealm";
            labelRealm.Size = new Size(113, 41);
            labelRealm.TabIndex = 13;
            labelRealm.Text = "Realm:";
            // 
            // labelDomain
            // 
            labelDomain.AutoSize = true;
            labelDomain.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelDomain.ForeColor = SystemColors.ButtonFace;
            labelDomain.Location = new Point(449, 219);
            labelDomain.Name = "labelDomain";
            labelDomain.Size = new Size(136, 41);
            labelDomain.TabIndex = 14;
            labelDomain.Text = "Domain:";
            // 
            // labelWeapon
            // 
            labelWeapon.AutoSize = true;
            labelWeapon.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelWeapon.ForeColor = SystemColors.ButtonFace;
            labelWeapon.Location = new Point(12, 332);
            labelWeapon.Name = "labelWeapon";
            labelWeapon.Size = new Size(142, 41);
            labelWeapon.TabIndex = 15;
            labelWeapon.Text = "Weapon:";
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelHP.ForeColor = SystemColors.ButtonFace;
            labelHP.Location = new Point(449, 325);
            labelHP.Name = "labelHP";
            labelHP.Size = new Size(67, 41);
            labelHP.TabIndex = 16;
            labelHP.Text = "HP:";
            labelHP.Click += labelHP_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonInsert.Location = new Point(362, 438);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(189, 54);
            buttonInsert.TabIndex = 17;
            buttonInsert.Text = "ADD GOD";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 30F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(40, 18);
            label1.Name = "label1";
            label1.Size = new Size(794, 59);
            label1.TabIndex = 18;
            label1.Text = "Create your own Norse god!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(2, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 11);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Location = new Point(414, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 304);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(2, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(872, 21);
            panel3.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(649, 438);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 22;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(872, 504);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(buttonInsert);
            Controls.Add(labelHP);
            Controls.Add(labelWeapon);
            Controls.Add(labelDomain);
            Controls.Add(labelRealm);
            Controls.Add(labelDescription);
            Controls.Add(labelName);
            Controls.Add(textBoxHP);
            Controls.Add(textBoxWeapon);
            Controls.Add(textBoxDomain);
            Controls.Add(textBoxRealm);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxRealm;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.TextBox textBoxWeapon;
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelRealm;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelWeapon;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Button buttonInsert;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
    }
}
