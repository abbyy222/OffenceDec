namespace Offence_Decision
{
    partial class DataVal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataVal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.DataM = new Guna.UI.WinForms.GunaComboBox();
            this.ProBtn = new Guna.UI.WinForms.GunaButton();
            this.StaffT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLinkLabel3 = new Guna.UI.WinForms.GunaLinkLabel();
            this.CrimeC = new Guna.UI.WinForms.GunaComboBox();
            this.NewCrimeT = new Guna.UI.WinForms.GunaLineTextBox();
            this.MisconductDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.AddBtn = new Guna.UI.WinForms.GunaButton();
            this.DeleteBtn = new Guna.UI.WinForms.GunaButton();
            this.EditBtn = new Guna.UI.WinForms.GunaButton();
            this.PunishmentT = new Guna.UI.WinForms.GunaLineTextBox();
            this.PunishmentL = new Guna.UI.WinForms.GunaLabel();
            this.NewCrimeL = new Guna.UI.WinForms.GunaLabel();
            this.NatureL = new Guna.UI.WinForms.GunaLabel();
            this.ViewT = new Guna.UI.WinForms.GunaLineTextBox();
            this.HomeB = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisconductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.DataM);
            this.gunaPanel1.Controls.Add(this.ProBtn);
            this.gunaPanel1.Controls.Add(this.StaffT);
            this.gunaPanel1.Controls.Add(this.gunaLinkLabel3);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(213, 701);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // DataM
            // 
            this.DataM.BackColor = System.Drawing.Color.Transparent;
            this.DataM.BaseColor = System.Drawing.Color.Transparent;
            this.DataM.BorderColor = System.Drawing.Color.Silver;
            this.DataM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DataM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataM.FocusedColor = System.Drawing.Color.Empty;
            this.DataM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DataM.ForeColor = System.Drawing.Color.Silver;
            this.DataM.FormattingEnabled = true;
            this.DataM.Items.AddRange(new object[] {
            "[FirstCat]",
            "[SECONDTAB]",
            "[THIRDTAB]"});
            this.DataM.Location = new System.Drawing.Point(47, 501);
            this.DataM.Name = "DataM";
            this.DataM.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataM.OnHoverItemForeColor = System.Drawing.Color.White;
            this.DataM.Size = new System.Drawing.Size(122, 26);
            this.DataM.TabIndex = 15;
            this.DataM.SelectedIndexChanged += new System.EventHandler(this.DataM_SelectedIndexChanged);
            // 
            // ProBtn
            // 
            this.ProBtn.AnimationHoverSpeed = 0.23F;
            this.ProBtn.AnimationSpeed = 0.06F;
            this.ProBtn.BaseColor = System.Drawing.Color.Yellow;
            this.ProBtn.BorderColor = System.Drawing.Color.Black;
            this.ProBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ProBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProBtn.ForeColor = System.Drawing.Color.Black;
            this.ProBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProBtn.Image")));
            this.ProBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ProBtn.Location = new System.Drawing.Point(30, 135);
            this.ProBtn.Name = "ProBtn";
            this.ProBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ProBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ProBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ProBtn.OnHoverImage = null;
            this.ProBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ProBtn.Size = new System.Drawing.Size(139, 34);
            this.ProBtn.TabIndex = 12;
            this.ProBtn.Text = "PROCEED";
            this.ProBtn.Click += new System.EventHandler(this.ProBtn_Click);
            // 
            // StaffT
            // 
            this.StaffT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.StaffT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StaffT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StaffT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffT.LineColor = System.Drawing.Color.Yellow;
            this.StaffT.Location = new System.Drawing.Point(24, 81);
            this.StaffT.Name = "StaffT";
            this.StaffT.PasswordChar = '\0';
            this.StaffT.SelectedText = "";
            this.StaffT.Size = new System.Drawing.Size(177, 47);
            this.StaffT.TabIndex = 12;
            this.StaffT.TextChanged += new System.EventHandler(this.StaffT_TextChanged);
            // 
            // gunaLinkLabel3
            // 
            this.gunaLinkLabel3.AutoSize = true;
            this.gunaLinkLabel3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel3.LinkColor = System.Drawing.Color.Black;
            this.gunaLinkLabel3.Location = new System.Drawing.Point(19, 37);
            this.gunaLinkLabel3.Name = "gunaLinkLabel3";
            this.gunaLinkLabel3.Size = new System.Drawing.Size(182, 29);
            this.gunaLinkLabel3.TabIndex = 12;
            this.gunaLinkLabel3.TabStop = true;
            this.gunaLinkLabel3.Text = "Enter your StaffID";
            // 
            // CrimeC
            // 
            this.CrimeC.BackColor = System.Drawing.Color.Transparent;
            this.CrimeC.BaseColor = System.Drawing.Color.Transparent;
            this.CrimeC.BorderColor = System.Drawing.Color.Yellow;
            this.CrimeC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CrimeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrimeC.FocusedColor = System.Drawing.Color.Empty;
            this.CrimeC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeC.ForeColor = System.Drawing.Color.Black;
            this.CrimeC.FormattingEnabled = true;
            this.CrimeC.Items.AddRange(new object[] {
            "FIRST CATEGORY MISCONDUCT",
            "SECOND CATEGORY MISCONDUCT",
            "THIRD CATEGORY MISCONDUCT",
            "ALL CATEGORIES OF MISCONDUCT"});
            this.CrimeC.Location = new System.Drawing.Point(557, 22);
            this.CrimeC.Name = "CrimeC";
            this.CrimeC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CrimeC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CrimeC.Size = new System.Drawing.Size(399, 36);
            this.CrimeC.TabIndex = 11;
            this.CrimeC.SelectedIndexChanged += new System.EventHandler(this.CrimeC_SelectedIndexChanged);
            // 
            // NewCrimeT
            // 
            this.NewCrimeT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.NewCrimeT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewCrimeT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewCrimeT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NewCrimeT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCrimeT.LineColor = System.Drawing.Color.Yellow;
            this.NewCrimeT.Location = new System.Drawing.Point(557, 65);
            this.NewCrimeT.Name = "NewCrimeT";
            this.NewCrimeT.PasswordChar = '\0';
            this.NewCrimeT.SelectedText = "";
            this.NewCrimeT.Size = new System.Drawing.Size(399, 62);
            this.NewCrimeT.TabIndex = 13;
            this.NewCrimeT.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // MisconductDGV
            // 
            this.MisconductDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.MisconductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MisconductDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MisconductDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MisconductDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MisconductDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MisconductDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MisconductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MisconductDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MisconductDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.MisconductDGV.EnableHeadersVisualStyles = false;
            this.MisconductDGV.GridColor = System.Drawing.Color.Red;
            this.MisconductDGV.Location = new System.Drawing.Point(219, 262);
            this.MisconductDGV.Name = "MisconductDGV";
            this.MisconductDGV.RowHeadersVisible = false;
            this.MisconductDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.MisconductDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MisconductDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MisconductDGV.Size = new System.Drawing.Size(1066, 389);
            this.MisconductDGV.TabIndex = 14;
            this.MisconductDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.MisconductDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.MisconductDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MisconductDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MisconductDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MisconductDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MisconductDGV.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MisconductDGV.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.MisconductDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.MisconductDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.MisconductDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MisconductDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MisconductDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MisconductDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.MisconductDGV.ThemeStyle.ReadOnly = false;
            this.MisconductDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MisconductDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MisconductDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MisconductDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MisconductDGV.ThemeStyle.RowsStyle.Height = 22;
            this.MisconductDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Aquamarine;
            this.MisconductDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MisconductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MisconductDGV_CellContentClick);
            // 
            // AddBtn
            // 
            this.AddBtn.AnimationHoverSpeed = 0.07F;
            this.AddBtn.AnimationSpeed = 0.03F;
            this.AddBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddBtn.BorderColor = System.Drawing.Color.Black;
            this.AddBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = null;
            this.AddBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.AddBtn.Location = new System.Drawing.Point(355, 202);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddBtn.OnHoverImage = null;
            this.AddBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AddBtn.Size = new System.Drawing.Size(101, 30);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Animated = true;
            this.DeleteBtn.AnimationHoverSpeed = 0.09F;
            this.DeleteBtn.AnimationSpeed = 0.04F;
            this.DeleteBtn.BaseColor = System.Drawing.Color.SpringGreen;
            this.DeleteBtn.BorderColor = System.Drawing.Color.Black;
            this.DeleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.Image = null;
            this.DeleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteBtn.Location = new System.Drawing.Point(822, 202);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteBtn.OnHoverImage = null;
            this.DeleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteBtn.Size = new System.Drawing.Size(114, 30);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AnimationHoverSpeed = 0.07F;
            this.EditBtn.AnimationSpeed = 0.03F;
            this.EditBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditBtn.BorderColor = System.Drawing.Color.Black;
            this.EditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditBtn.FocusedColor = System.Drawing.Color.Empty;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Image = null;
            this.EditBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.EditBtn.Location = new System.Drawing.Point(590, 202);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EditBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.EditBtn.OnHoverImage = null;
            this.EditBtn.OnPressedColor = System.Drawing.Color.Black;
            this.EditBtn.Size = new System.Drawing.Size(114, 30);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "Edit";
            this.EditBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditBtn.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // PunishmentT
            // 
            this.PunishmentT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PunishmentT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PunishmentT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PunishmentT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunishmentT.LineColor = System.Drawing.Color.Yellow;
            this.PunishmentT.Location = new System.Drawing.Point(557, 135);
            this.PunishmentT.Name = "PunishmentT";
            this.PunishmentT.PasswordChar = '\0';
            this.PunishmentT.SelectedText = "";
            this.PunishmentT.Size = new System.Drawing.Size(399, 42);
            this.PunishmentT.TabIndex = 19;
            this.PunishmentT.TextChanged += new System.EventHandler(this.PunishmentT_TextChanged);
            // 
            // PunishmentL
            // 
            this.PunishmentL.AutoSize = true;
            this.PunishmentL.BackColor = System.Drawing.Color.Transparent;
            this.PunishmentL.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunishmentL.ForeColor = System.Drawing.Color.Black;
            this.PunishmentL.Location = new System.Drawing.Point(322, 148);
            this.PunishmentL.Name = "PunishmentL";
            this.PunishmentL.Size = new System.Drawing.Size(172, 29);
            this.PunishmentL.TabIndex = 20;
            this.PunishmentL.Text = "Add Punishment";
            this.PunishmentL.Click += new System.EventHandler(this.PunishmentL_Click);
            // 
            // NewCrimeL
            // 
            this.NewCrimeL.AutoSize = true;
            this.NewCrimeL.BackColor = System.Drawing.Color.Transparent;
            this.NewCrimeL.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCrimeL.ForeColor = System.Drawing.Color.Black;
            this.NewCrimeL.Location = new System.Drawing.Point(322, 81);
            this.NewCrimeL.Name = "NewCrimeL";
            this.NewCrimeL.Size = new System.Drawing.Size(156, 29);
            this.NewCrimeL.TabIndex = 21;
            this.NewCrimeL.Text = "Add New Crime";
            // 
            // NatureL
            // 
            this.NatureL.AutoSize = true;
            this.NatureL.BackColor = System.Drawing.Color.Transparent;
            this.NatureL.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NatureL.ForeColor = System.Drawing.Color.Black;
            this.NatureL.Location = new System.Drawing.Point(322, 29);
            this.NatureL.Name = "NatureL";
            this.NatureL.Size = new System.Drawing.Size(165, 29);
            this.NatureL.TabIndex = 22;
            this.NatureL.Text = "Nature of Crime";
            this.NatureL.Click += new System.EventHandler(this.NatureL_Click);
            // 
            // ViewT
            // 
            this.ViewT.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ViewT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ViewT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ViewT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ViewT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ViewT.LineColor = System.Drawing.Color.Transparent;
            this.ViewT.Location = new System.Drawing.Point(380, 657);
            this.ViewT.Name = "ViewT";
            this.ViewT.PasswordChar = '\0';
            this.ViewT.SelectedText = "";
            this.ViewT.Size = new System.Drawing.Size(124, 26);
            this.ViewT.TabIndex = 23;
            this.ViewT.TextChanged += new System.EventHandler(this.ViewT_TextChanged);
            // 
            // HomeB
            // 
            this.HomeB.AnimationHoverSpeed = 0.07F;
            this.HomeB.AnimationSpeed = 0.03F;
            this.HomeB.BaseColor = System.Drawing.Color.Red;
            this.HomeB.BorderColor = System.Drawing.Color.Black;
            this.HomeB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeB.FocusedColor = System.Drawing.Color.Empty;
            this.HomeB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeB.ForeColor = System.Drawing.Color.White;
            this.HomeB.Image = ((System.Drawing.Image)(resources.GetObject("HomeB.Image")));
            this.HomeB.ImageSize = new System.Drawing.Size(20, 20);
            this.HomeB.Location = new System.Drawing.Point(1093, 659);
            this.HomeB.Name = "HomeB";
            this.HomeB.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.HomeB.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HomeB.OnHoverForeColor = System.Drawing.Color.White;
            this.HomeB.OnHoverImage = null;
            this.HomeB.OnPressedColor = System.Drawing.Color.Black;
            this.HomeB.Size = new System.Drawing.Size(160, 42);
            this.HomeB.TabIndex = 52;
            this.HomeB.Text = "Back To Home";
            this.HomeB.Click += new System.EventHandler(this.HomeB_Click);
            // 
            // DataVal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 701);
            this.Controls.Add(this.HomeB);
            this.Controls.Add(this.ViewT);
            this.Controls.Add(this.NatureL);
            this.Controls.Add(this.NewCrimeL);
            this.Controls.Add(this.PunishmentL);
            this.Controls.Add(this.PunishmentT);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MisconductDGV);
            this.Controls.Add(this.NewCrimeT);
            this.Controls.Add(this.CrimeC);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataVal";
            this.Text = "DataVal";
            this.Load += new System.EventHandler(this.DataVal_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisconductDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton ProBtn;
        private Guna.UI.WinForms.GunaLineTextBox StaffT;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel3;
        private Guna.UI.WinForms.GunaComboBox CrimeC;
        private Guna.UI.WinForms.GunaLineTextBox NewCrimeT;
        private Guna.UI.WinForms.GunaDataGridView MisconductDGV;
        private Guna.UI.WinForms.GunaComboBox DataM;
        private Guna.UI.WinForms.GunaButton AddBtn;
        private Guna.UI.WinForms.GunaButton DeleteBtn;
        private Guna.UI.WinForms.GunaButton EditBtn;
        private Guna.UI.WinForms.GunaLineTextBox PunishmentT;
        private Guna.UI.WinForms.GunaLabel PunishmentL;
        private Guna.UI.WinForms.GunaLabel NewCrimeL;
        private Guna.UI.WinForms.GunaLabel NatureL;
        private Guna.UI.WinForms.GunaLineTextBox ViewT;
        private Guna.UI.WinForms.GunaButton HomeB;
    }
}