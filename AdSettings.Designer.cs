namespace Offence_Decision
{
    partial class AdSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdSettings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.MyPic = new System.Windows.Forms.PictureBox();
            this.FullNameT = new Guna.UI.WinForms.GunaLineTextBox();
            this.EmailT = new Guna.UI.WinForms.GunaLineTextBox();
            this.PhoneT = new Guna.UI.WinForms.GunaLineTextBox();
            this.PositionT = new Guna.UI.WinForms.GunaLineTextBox();
            this.GenerateBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.staffId = new Guna.UI.WinForms.GunaLabel();
            this.Add = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.BrowseBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SaveBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPic)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(219, 134);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "FullName";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(219, 345);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 25);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Position";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(219, 181);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Email";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(219, 255);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(283, 25);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "Contact Phone Number";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // MyPic
            // 
            this.MyPic.Image = ((System.Drawing.Image)(resources.GetObject("MyPic.Image")));
            this.MyPic.Location = new System.Drawing.Point(817, 12);
            this.MyPic.Name = "MyPic";
            this.MyPic.Size = new System.Drawing.Size(176, 154);
            this.MyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPic.TabIndex = 40;
            this.MyPic.TabStop = false;
            // 
            // FullNameT
            // 
            this.FullNameT.BackColor = System.Drawing.Color.Gray;
            this.FullNameT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullNameT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FullNameT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameT.LineColor = System.Drawing.Color.Gainsboro;
            this.FullNameT.Location = new System.Drawing.Point(527, 124);
            this.FullNameT.Name = "FullNameT";
            this.FullNameT.PasswordChar = '\0';
            this.FullNameT.SelectedText = "";
            this.FullNameT.Size = new System.Drawing.Size(252, 35);
            this.FullNameT.TabIndex = 42;
            this.FullNameT.TextChanged += new System.EventHandler(this.FullNameT_TextChanged);
            // 
            // EmailT
            // 
            this.EmailT.BackColor = System.Drawing.Color.Gray;
            this.EmailT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailT.LineColor = System.Drawing.Color.Gainsboro;
            this.EmailT.Location = new System.Drawing.Point(527, 180);
            this.EmailT.Name = "EmailT";
            this.EmailT.PasswordChar = '\0';
            this.EmailT.SelectedText = "";
            this.EmailT.Size = new System.Drawing.Size(252, 34);
            this.EmailT.TabIndex = 43;
            // 
            // PhoneT
            // 
            this.PhoneT.BackColor = System.Drawing.Color.Gray;
            this.PhoneT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhoneT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneT.LineColor = System.Drawing.Color.Gainsboro;
            this.PhoneT.Location = new System.Drawing.Point(527, 254);
            this.PhoneT.Name = "PhoneT";
            this.PhoneT.PasswordChar = '\0';
            this.PhoneT.SelectedText = "";
            this.PhoneT.Size = new System.Drawing.Size(252, 33);
            this.PhoneT.TabIndex = 44;
            this.PhoneT.TextChanged += new System.EventHandler(this.PhoneT_TextChanged);
            // 
            // PositionT
            // 
            this.PositionT.BackColor = System.Drawing.Color.Gray;
            this.PositionT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PositionT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PositionT.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionT.LineColor = System.Drawing.Color.Gainsboro;
            this.PositionT.Location = new System.Drawing.Point(527, 335);
            this.PositionT.Name = "PositionT";
            this.PositionT.PasswordChar = '\0';
            this.PositionT.SelectedText = "";
            this.PositionT.Size = new System.Drawing.Size(252, 37);
            this.PositionT.TabIndex = 45;
            this.PositionT.TextChanged += new System.EventHandler(this.gunaLineTextBox3_TextChanged);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Animated = true;
            this.GenerateBtn.AnimationHoverSpeed = 0.09F;
            this.GenerateBtn.AnimationSpeed = 0.05F;
            this.GenerateBtn.BaseColor = System.Drawing.Color.SpringGreen;
            this.GenerateBtn.BorderColor = System.Drawing.Color.Black;
            this.GenerateBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.GenerateBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.GenerateBtn.CheckedForeColor = System.Drawing.Color.White;
            this.GenerateBtn.CheckedImage = null;
            this.GenerateBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.GenerateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GenerateBtn.FocusedColor = System.Drawing.Color.Empty;
            this.GenerateBtn.Font = new System.Drawing.Font("Script MT Bold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn.ForeColor = System.Drawing.Color.Black;
            this.GenerateBtn.Image = null;
            this.GenerateBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.GenerateBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.GenerateBtn.Location = new System.Drawing.Point(224, 413);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.GenerateBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GenerateBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.GenerateBtn.OnHoverImage = null;
            this.GenerateBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.GenerateBtn.OnPressedColor = System.Drawing.Color.Black;
            this.GenerateBtn.Size = new System.Drawing.Size(149, 46);
            this.GenerateBtn.TabIndex = 46;
            this.GenerateBtn.Text = "Generate ID";
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // staffId
            // 
            this.staffId.AutoSize = true;
            this.staffId.BackColor = System.Drawing.Color.Transparent;
            this.staffId.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffId.Location = new System.Drawing.Point(503, 413);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(78, 29);
            this.staffId.TabIndex = 47;
            this.staffId.Text = "StaffID";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(388, 12);
            this.Add.Name = "Add";
            this.Add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.Add.Size = new System.Drawing.Size(252, 31);
            this.Add.TabIndex = 49;
            this.Add.Values.Heading = "Add New Admin";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.AllowAnimations = true;
            this.BrowseBtn.AllowMouseEffects = true;
            this.BrowseBtn.AllowToggling = false;
            this.BrowseBtn.AnimationSpeed = 200;
            this.BrowseBtn.AutoGenerateColors = true;
            this.BrowseBtn.AutoRoundBorders = true;
            this.BrowseBtn.AutoSizeLeftIcon = true;
            this.BrowseBtn.AutoSizeRightIcon = true;
            this.BrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBtn.BackColor1 = System.Drawing.Color.GreenYellow;
            this.BrowseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseBtn.BackgroundImage")));
            this.BrowseBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BrowseBtn.ButtonText = "Browse";
            this.BrowseBtn.ButtonTextMarginLeft = 0;
            this.BrowseBtn.ColorContrastOnClick = 45;
            this.BrowseBtn.ColorContrastOnHover = 45;
            this.BrowseBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BrowseBtn.CustomizableEdges = borderEdges1;
            this.BrowseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BrowseBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BrowseBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BrowseBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BrowseBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BrowseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.ForeColor = System.Drawing.Color.Black;
            this.BrowseBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BrowseBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BrowseBtn.IconMarginLeft = 11;
            this.BrowseBtn.IconPadding = 10;
            this.BrowseBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BrowseBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BrowseBtn.IconSize = 25;
            this.BrowseBtn.IdleBorderColor = System.Drawing.Color.Black;
            this.BrowseBtn.IdleBorderRadius = 39;
            this.BrowseBtn.IdleBorderThickness = 3;
            this.BrowseBtn.IdleFillColor = System.Drawing.Color.GreenYellow;
            this.BrowseBtn.IdleIconLeftImage = null;
            this.BrowseBtn.IdleIconRightImage = null;
            this.BrowseBtn.IndicateFocus = false;
            this.BrowseBtn.Location = new System.Drawing.Point(850, 193);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BrowseBtn.OnDisabledState.BorderRadius = 1;
            this.BrowseBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BrowseBtn.OnDisabledState.BorderThickness = 3;
            this.BrowseBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BrowseBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BrowseBtn.OnDisabledState.IconLeftImage = null;
            this.BrowseBtn.OnDisabledState.IconRightImage = null;
            this.BrowseBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.BrowseBtn.onHoverState.BorderRadius = 1;
            this.BrowseBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BrowseBtn.onHoverState.BorderThickness = 3;
            this.BrowseBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.BrowseBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BrowseBtn.onHoverState.IconLeftImage = null;
            this.BrowseBtn.onHoverState.IconRightImage = null;
            this.BrowseBtn.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.BrowseBtn.OnIdleState.BorderRadius = 1;
            this.BrowseBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BrowseBtn.OnIdleState.BorderThickness = 3;
            this.BrowseBtn.OnIdleState.FillColor = System.Drawing.Color.GreenYellow;
            this.BrowseBtn.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BrowseBtn.OnIdleState.IconLeftImage = null;
            this.BrowseBtn.OnIdleState.IconRightImage = null;
            this.BrowseBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BrowseBtn.OnPressedState.BorderRadius = 1;
            this.BrowseBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BrowseBtn.OnPressedState.BorderThickness = 3;
            this.BrowseBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(140)))), ((int)(((byte)(25)))));
            this.BrowseBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BrowseBtn.OnPressedState.IconLeftImage = null;
            this.BrowseBtn.OnPressedState.IconRightImage = null;
            this.BrowseBtn.Size = new System.Drawing.Size(128, 45);
            this.BrowseBtn.TabIndex = 51;
            this.BrowseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowseBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BrowseBtn.TextMarginLeft = 0;
            this.BrowseBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.BrowseBtn.UseDefaultRadiusAndThickness = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Animated = true;
            this.SaveBtn.AnimationHoverSpeed = 0.09F;
            this.SaveBtn.AnimationSpeed = 0.05F;
            this.SaveBtn.BaseColor = System.Drawing.Color.Chocolate;
            this.SaveBtn.BorderColor = System.Drawing.Color.Black;
            this.SaveBtn.BorderSize = 2;
            this.SaveBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveBtn.CheckedForeColor = System.Drawing.Color.White;
            this.SaveBtn.CheckedImage = null;
            this.SaveBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SaveBtn.Font = new System.Drawing.Font("Script MT Bold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Image = null;
            this.SaveBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveBtn.Location = new System.Drawing.Point(829, 479);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SaveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SaveBtn.OnHoverImage = null;
            this.SaveBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.SaveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SaveBtn.Size = new System.Drawing.Size(149, 46);
            this.SaveBtn.TabIndex = 52;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Gold;
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(200, 554);
            this.gunaPanel1.TabIndex = 53;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(24, 14);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(159, 145);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 54;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(24, 397);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(159, 145);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 55;
            this.gunaPictureBox2.TabStop = false;
            // 
            // AdSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1014, 554);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.staffId);
            this.Controls.Add(this.PositionT);
            this.Controls.Add(this.PhoneT);
            this.Controls.Add(this.EmailT);
            this.Controls.Add(this.FullNameT);
            this.Controls.Add(this.MyPic);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdSettings";
            this.Load += new System.EventHandler(this.AdSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyPic)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.PictureBox MyPic;
        private Guna.UI.WinForms.GunaLineTextBox FullNameT;
        private Guna.UI.WinForms.GunaLineTextBox EmailT;
        private Guna.UI.WinForms.GunaLineTextBox PhoneT;
        private Guna.UI.WinForms.GunaLineTextBox PositionT;
        private Guna.UI.WinForms.GunaAdvenceButton GenerateBtn;
        private Guna.UI.WinForms.GunaLabel staffId;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader Add;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BrowseBtn;
        private Guna.UI.WinForms.GunaAdvenceButton SaveBtn;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}