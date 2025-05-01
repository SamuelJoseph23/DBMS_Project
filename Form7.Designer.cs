namespace DBMS_Project
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            buttonForm1 = new Button();
            buttonForm2 = new Button();
            buttonForm4 = new Button();
            buttonForm5 = new Button();
            buttonForm6 = new Button();
            labelTitle = new Label();
            labelDateTime = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonForm1
            // 
            buttonForm1.BackColor = Color.LightSkyBlue;
            buttonForm1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            buttonForm1.Location = new Point(45, 110);
            buttonForm1.Name = "buttonForm1";
            buttonForm1.Size = new Size(200, 50);
            buttonForm1.TabIndex = 0;
            buttonForm1.Text = "Realm-Pedia";
            buttonForm1.UseVisualStyleBackColor = false;
            buttonForm1.Click += buttonForm1_Click;
            // 
            // buttonForm2
            // 
            buttonForm2.BackColor = Color.LightSkyBlue;
            buttonForm2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            buttonForm2.Location = new Point(183, 212);
            buttonForm2.Name = "buttonForm2";
            buttonForm2.Size = new Size(200, 50);
            buttonForm2.TabIndex = 1;
            buttonForm2.Text = "God Maker";
            buttonForm2.UseVisualStyleBackColor = false;
            buttonForm2.Click += buttonForm2_Click;
            // 
            // buttonForm4
            // 
            buttonForm4.BackColor = Color.LightSkyBlue;
            buttonForm4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            buttonForm4.Location = new Point(338, 312);
            buttonForm4.Name = "buttonForm4";
            buttonForm4.Size = new Size(200, 50);
            buttonForm4.TabIndex = 2;
            buttonForm4.Text = "Battle!";
            buttonForm4.UseVisualStyleBackColor = false;
            buttonForm4.Click += buttonForm4_Click;
            // 
            // buttonForm5
            // 
            buttonForm5.BackColor = Color.LightSkyBlue;
            buttonForm5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            buttonForm5.Location = new Point(615, 110);
            buttonForm5.Name = "buttonForm5";
            buttonForm5.Size = new Size(200, 50);
            buttonForm5.TabIndex = 3;
            buttonForm5.Text = "God-Pedia";
            buttonForm5.UseVisualStyleBackColor = false;
            buttonForm5.Click += buttonForm5_Click;
            // 
            // buttonForm6
            // 
            buttonForm6.BackColor = Color.LightSkyBlue;
            buttonForm6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            buttonForm6.Location = new Point(338, 110);
            buttonForm6.Name = "buttonForm6";
            buttonForm6.Size = new Size(200, 50);
            buttonForm6.TabIndex = 4;
            buttonForm6.Text = "Weapon-Pedia";
            buttonForm6.UseVisualStyleBackColor = false;
            buttonForm6.Click += buttonForm6_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Stencil", 36F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(265, -3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(365, 71);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "MAIN MENU";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelDateTime.ForeColor = Color.White;
            labelDateTime.Location = new Point(245, 300);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(0, 24);
            labelDateTime.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 10);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button1.Location = new Point(483, 212);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 8;
            button1.Text = "Weapon Maker";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(585, 312);
            button2.Name = "button2";
            button2.Size = new Size(184, 54);
            button2.TabIndex = 9;
            button2.Text = "SearchWeapon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(872, 504);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(labelDateTime);
            Controls.Add(labelTitle);
            Controls.Add(buttonForm6);
            Controls.Add(buttonForm5);
            Controls.Add(buttonForm4);
            Controls.Add(buttonForm2);
            Controls.Add(buttonForm1);
            Name = "Form7";
            Text = "Main Menu";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button buttonForm1;
        private System.Windows.Forms.Button buttonForm2;
        private System.Windows.Forms.Button buttonForm4;
        private System.Windows.Forms.Button buttonForm5;
        private System.Windows.Forms.Button buttonForm6;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDateTime;
        private Panel panel1;
        private Button button1;
        private Button button2;
    }
}

