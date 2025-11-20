namespace Offence_Decision
{
    partial class Auth3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth3));
            this.Proceed = new Guna.UI.WinForms.GunaGradientButton();
            this.StaffT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // Proceed
            // 
            this.Proceed.AnimationHoverSpeed = 0.07F;
            this.Proceed.AnimationSpeed = 0.03F;
            this.Proceed.BaseColor1 = System.Drawing.Color.Red;
            this.Proceed.BaseColor2 = System.Drawing.Color.Indigo;
            this.Proceed.BorderColor = System.Drawing.Color.Black;
            this.Proceed.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Proceed.FocusedColor = System.Drawing.Color.Empty;
            this.Proceed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed.ForeColor = System.Drawing.Color.White;
            this.Proceed.Image = ((System.Drawing.Image)(resources.GetObject("Proceed.Image")));
            this.Proceed.ImageSize = new System.Drawing.Size(20, 20);
            this.Proceed.Location = new System.Drawing.Point(352, 203);
            this.Proceed.Name = "Proceed";
            this.Proceed.OnHoverBaseColor1 = System.Drawing.Color.IndianRed;
            this.Proceed.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Proceed.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Proceed.OnHoverForeColor = System.Drawing.Color.White;
            this.Proceed.OnHoverImage = null;
            this.Proceed.OnPressedColor = System.Drawing.Color.Black;
            this.Proceed.Size = new System.Drawing.Size(160, 42);
            this.Proceed.TabIndex = 8;
            this.Proceed.Text = "Proceed";
            this.Proceed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // StaffT
            // 
            this.StaffT.BackColor = System.Drawing.Color.OliveDrab;
            this.StaffT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StaffT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffT.LineColor = System.Drawing.Color.Gainsboro;
            this.StaffT.Location = new System.Drawing.Point(186, 106);
            this.StaffT.Name = "StaffT";
            this.StaffT.PasswordChar = '\0';
            this.StaffT.SelectedText = "";
            this.StaffT.Size = new System.Drawing.Size(216, 40);
            this.StaffT.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 33);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(190, 25);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Enter Admin StaffID";
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(469, 0);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(43, 38);
            this.gunaImageButton1.TabIndex = 9;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // Auth3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(515, 257);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.StaffT);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Auth3";
            this.Load += new System.EventHandler(this.Auth3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton Proceed;
        private Guna.UI.WinForms.GunaLineTextBox StaffT;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}