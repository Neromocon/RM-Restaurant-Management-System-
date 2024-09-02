namespace _RM
{
    partial class frmMain
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnKitchen = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.guna2Panel1.Controls.Add(this.btnSettings);
            this.guna2Panel1.Controls.Add(this.btnReports);
            this.guna2Panel1.Controls.Add(this.btnKitchen);
            this.guna2Panel1.Controls.Add(this.btnPOS);
            this.guna2Panel1.Controls.Add(this.btnStaff);
            this.guna2Panel1.Controls.Add(this.btnTable);
            this.guna2Panel1.Controls.Add(this.btnProduct);
            this.guna2Panel1.Controls.Add(this.btnCategory);
            this.guna2Panel1.Controls.Add(this.btnHome);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(175, 650);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management System";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel2.Controls.Add(this.lblUser);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(175, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(808, 50);
            this.guna2Panel2.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(6, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(188, 25);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Management System";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(750, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(699, 13);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(648, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ControlsPanel.Controls.Add(this.guna2PictureBox2);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(175, 50);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(808, 600);
            this.ControlsPanel.TabIndex = 0;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::_RM.Properties.Resources.Restaurant_3_2;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(11, 29);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(785, 453);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoRoundedCorners = true;
            this.btnSettings.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSettings.BorderRadius = 21;
            this.btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnSettings.CheckedState.Image = global::_RM.Properties.Resources.Setting_Reversal;
            this.btnSettings.CustomizableEdges.BottomRight = false;
            this.btnSettings.CustomizableEdges.TopRight = false;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::_RM.Properties.Resources.Setting;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSettings.Location = new System.Drawing.Point(37, 589);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(138, 45);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnReports
            // 
            this.btnReports.AutoRoundedCorners = true;
            this.btnReports.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReports.BorderRadius = 21;
            this.btnReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReports.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnReports.CheckedState.Image = global::_RM.Properties.Resources.Setting_Reversal;
            this.btnReports.CustomizableEdges.BottomRight = false;
            this.btnReports.CustomizableEdges.TopRight = false;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::_RM.Properties.Resources.Bill;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnReports.Location = new System.Drawing.Point(37, 538);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(138, 45);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "리포트";
            this.btnReports.TextOffset = new System.Drawing.Point(10, 0);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.AutoRoundedCorners = true;
            this.btnKitchen.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKitchen.BorderRadius = 21;
            this.btnKitchen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKitchen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnKitchen.CheckedState.Image = global::_RM.Properties.Resources.Kitchen_Reversal;
            this.btnKitchen.CustomizableEdges.BottomRight = false;
            this.btnKitchen.CustomizableEdges.TopRight = false;
            this.btnKitchen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKitchen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKitchen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKitchen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKitchen.FillColor = System.Drawing.Color.Transparent;
            this.btnKitchen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.ForeColor = System.Drawing.Color.White;
            this.btnKitchen.Image = global::_RM.Properties.Resources.Kitchen;
            this.btnKitchen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKitchen.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnKitchen.Location = new System.Drawing.Point(37, 487);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(138, 45);
            this.btnKitchen.TabIndex = 2;
            this.btnKitchen.Text = "주 방";
            this.btnKitchen.TextOffset = new System.Drawing.Point(10, 0);
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.AutoRoundedCorners = true;
            this.btnPOS.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPOS.BorderRadius = 21;
            this.btnPOS.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPOS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnPOS.CheckedState.Image = global::_RM.Properties.Resources.POS_Reversal;
            this.btnPOS.CustomizableEdges.BottomRight = false;
            this.btnPOS.CustomizableEdges.TopRight = false;
            this.btnPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPOS.FillColor = System.Drawing.Color.Transparent;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Image = global::_RM.Properties.Resources.POS;
            this.btnPOS.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPOS.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPOS.Location = new System.Drawing.Point(37, 436);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(138, 45);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.AutoRoundedCorners = true;
            this.btnStaff.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStaff.BorderRadius = 21;
            this.btnStaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnStaff.CheckedState.Image = global::_RM.Properties.Resources.Staff_Reversal;
            this.btnStaff.CustomizableEdges.BottomRight = false;
            this.btnStaff.CustomizableEdges.TopRight = false;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::_RM.Properties.Resources.Staff;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnStaff.Location = new System.Drawing.Point(37, 385);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(138, 45);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "직 원";
            this.btnStaff.TextOffset = new System.Drawing.Point(10, 0);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnTable
            // 
            this.btnTable.AutoRoundedCorners = true;
            this.btnTable.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTable.BorderRadius = 21;
            this.btnTable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnTable.CheckedState.Image = global::_RM.Properties.Resources.Table_Reversal;
            this.btnTable.CustomizableEdges.BottomRight = false;
            this.btnTable.CustomizableEdges.TopRight = false;
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.FillColor = System.Drawing.Color.Transparent;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Image = global::_RM.Properties.Resources.Table;
            this.btnTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTable.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnTable.Location = new System.Drawing.Point(37, 334);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(138, 45);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "테이블";
            this.btnTable.TextOffset = new System.Drawing.Point(10, 0);
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.AutoRoundedCorners = true;
            this.btnProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnProduct.BorderRadius = 21;
            this.btnProduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProduct.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnProduct.CheckedState.Image = global::_RM.Properties.Resources.Products_Reversal;
            this.btnProduct.CustomizableEdges.BottomRight = false;
            this.btnProduct.CustomizableEdges.TopRight = false;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::_RM.Properties.Resources.Products;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnProduct.Location = new System.Drawing.Point(37, 283);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(138, 45);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "제 품";
            this.btnProduct.TextOffset = new System.Drawing.Point(10, 0);
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.AutoRoundedCorners = true;
            this.btnCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCategory.BorderRadius = 21;
            this.btnCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnCategory.CheckedState.Image = global::_RM.Properties.Resources.Categories_Reversal;
            this.btnCategory.CustomizableEdges.BottomRight = false;
            this.btnCategory.CustomizableEdges.TopRight = false;
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.FillColor = System.Drawing.Color.Transparent;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::_RM.Properties.Resources.Categories;
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCategory.Location = new System.Drawing.Point(37, 232);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(138, 45);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "분 류";
            this.btnCategory.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.BorderRadius = 21;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(180)))));
            this.btnHome.CheckedState.Image = global::_RM.Properties.Resources._home_Reversal;
            this.btnHome.CustomizableEdges.BottomRight = false;
            this.btnHome.CustomizableEdges.TopRight = false;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::_RM.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHome.Location = new System.Drawing.Point(37, 181);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(138, 45);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextOffset = new System.Drawing.Point(10, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::_RM.Properties.Resources._Restaurant_Logo_Reversal;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(37, 32);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(983, 650);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ControlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel ControlsPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnTable;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnKitchen;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private System.Windows.Forms.Label lblUser;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}