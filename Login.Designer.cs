namespace Offence_Decision
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoleC = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Signup = new Guna.UI.WinForms.GunaLinkLabel();
            this.loginB = new Guna.UI.WinForms.GunaGradientButton();
            this.NameT = new Guna.UI.WinForms.GunaLineTextBox();
            this.idT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.StaffT = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.RoleC);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLinkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Signup);
            this.panel1.Controls.Add(this.loginB);
            this.panel1.Controls.Add(this.NameT);
            this.panel1.Controls.Add(this.idT);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.StaffT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 473);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RoleC
            // 
            this.RoleC.BackColor = System.Drawing.Color.Transparent;
            this.RoleC.BaseColor = System.Drawing.Color.DimGray;
            this.RoleC.BorderColor = System.Drawing.Color.Silver;
            this.RoleC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleC.FocusedColor = System.Drawing.Color.Empty;
            this.RoleC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleC.ForeColor = System.Drawing.Color.Black;
            this.RoleC.FormattingEnabled = true;
            this.RoleC.Items.AddRange(new object[] {
            "Administrator",
            "Guest"});
            this.RoleC.Location = new System.Drawing.Point(256, 109);
            this.RoleC.Name = "RoleC";
            this.RoleC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoleC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.RoleC.Size = new System.Drawing.Size(369, 30);
            this.RoleC.TabIndex = 10;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Black;
            this.gunaLabel3.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Yellow;
            this.gunaLabel3.Location = new System.Drawing.Point(71, 115);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(71, 35);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "Role";
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Red;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(312, 424);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(116, 32);
            this.gunaLinkLabel1.TabIndex = 8;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "ForgotID";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(725, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Signup
            // 
            this.Signup.ActiveLinkColor = System.Drawing.Color.Red;
            this.Signup.AutoSize = true;
            this.Signup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.LinkColor = System.Drawing.Color.LightCoral;
            this.Signup.Location = new System.Drawing.Point(54, 424);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(94, 32);
            this.Signup.TabIndex = 6;
            this.Signup.TabStop = true;
            this.Signup.Text = "Signup";
            this.Signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signup_LinkClicked);
            // 
            // loginB
            // 
            this.loginB.Animated = true;
            this.loginB.AnimationHoverSpeed = 0.09F;
            this.loginB.AnimationSpeed = 0.05F;
            this.loginB.BaseColor1 = System.Drawing.Color.OrangeRed;
            this.loginB.BaseColor2 = System.Drawing.Color.Crimson;
            this.loginB.BorderColor = System.Drawing.Color.Black;
            this.loginB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginB.FocusedColor = System.Drawing.Color.Empty;
            this.loginB.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginB.ForeColor = System.Drawing.Color.Yellow;
            this.loginB.Image = null;
            this.loginB.ImageSize = new System.Drawing.Size(20, 20);
            this.loginB.Location = new System.Drawing.Point(599, 410);
            this.loginB.Name = "loginB";
            this.loginB.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.loginB.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.loginB.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginB.OnHoverForeColor = System.Drawing.Color.White;
            this.loginB.OnHoverImage = null;
            this.loginB.OnPressedColor = System.Drawing.Color.Black;
            this.loginB.Size = new System.Drawing.Size(137, 46);
            this.loginB.TabIndex = 5;
            this.loginB.Text = "Login";
            this.loginB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginB.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // NameT
            // 
            this.NameT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NameT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameT.LineColor = System.Drawing.Color.Gainsboro;
            this.NameT.Location = new System.Drawing.Point(256, 275);
            this.NameT.Name = "NameT";
            this.NameT.PasswordChar = '\0';
            this.NameT.SelectedText = "";
            this.NameT.Size = new System.Drawing.Size(369, 36);
            this.NameT.TabIndex = 4;
            // 
            // idT
            // 
            this.idT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.idT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idT.LineColor = System.Drawing.Color.Gainsboro;
            this.idT.Location = new System.Drawing.Point(256, 172);
            this.idT.Name = "idT";
            this.idT.PasswordChar = '\0';
            this.idT.SelectedText = "";
            this.idT.Size = new System.Drawing.Size(369, 36);
            this.idT.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Black;
            this.gunaLabel2.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.gunaLabel2.Location = new System.Drawing.Point(312, 32);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(119, 35);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Welcome";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Black;
            this.gunaLabel1.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.gunaLabel1.Location = new System.Drawing.Point(41, 275);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(139, 35);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "FullName";
            // 
            // StaffT
            // 
            this.StaffT.AutoSize = true;
            this.StaffT.BackColor = System.Drawing.Color.Black;
            this.StaffT.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffT.ForeColor = System.Drawing.Color.Yellow;
            this.StaffT.Location = new System.Drawing.Point(54, 172);
            this.StaffT.Name = "StaffT";
            this.StaffT.Size = new System.Drawing.Size(109, 35);
            this.StaffT.TabIndex = 0;
            this.StaffT.Text = "StaffId";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 473);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLinkLabel Signup;
        private Guna.UI.WinForms.GunaGradientButton loginB;
        private Guna.UI.WinForms.GunaLineTextBox NameT;
        private Guna.UI.WinForms.GunaLineTextBox idT;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel StaffT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaComboBox RoleC;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
    }
}

