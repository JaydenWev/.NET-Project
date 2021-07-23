
namespace Dashboard
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.contactBtn = new System.Windows.Forms.Button();
            this.calenderBtn = new System.Windows.Forms.Button();
            this.analyticsBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userTxtLbl = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.closeBtn = new System.Windows.Forms.Button();
            this.maximizeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.navigationPanel.Controls.Add(this.PnlNav);
            this.navigationPanel.Controls.Add(this.settingsBtn);
            this.navigationPanel.Controls.Add(this.contactBtn);
            this.navigationPanel.Controls.Add(this.calenderBtn);
            this.navigationPanel.Controls.Add(this.analyticsBtn);
            this.navigationPanel.Controls.Add(this.dashboardBtn);
            this.navigationPanel.Controls.Add(this.panel2);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(220, 577);
            this.navigationPanel.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 200);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 6;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.settingsBtn.Image = global::Dashboard.Properties.Resources.Settings_icon;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsBtn.Location = new System.Drawing.Point(0, 535);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(220, 42);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            this.settingsBtn.Leave += new System.EventHandler(this.settingsBtn_Leave);
            // 
            // contactBtn
            // 
            this.contactBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactBtn.FlatAppearance.BorderSize = 0;
            this.contactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.contactBtn.Image = global::Dashboard.Properties.Resources.Contact_icon;
            this.contactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contactBtn.Location = new System.Drawing.Point(0, 270);
            this.contactBtn.Name = "contactBtn";
            this.contactBtn.Size = new System.Drawing.Size(220, 42);
            this.contactBtn.TabIndex = 4;
            this.contactBtn.Text = "Contact";
            this.contactBtn.UseVisualStyleBackColor = true;
            this.contactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            this.contactBtn.Leave += new System.EventHandler(this.contactBtn_Leave);
            // 
            // calenderBtn
            // 
            this.calenderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.calenderBtn.FlatAppearance.BorderSize = 0;
            this.calenderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calenderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calenderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.calenderBtn.Image = global::Dashboard.Properties.Resources.Calender_icon;
            this.calenderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calenderBtn.Location = new System.Drawing.Point(0, 228);
            this.calenderBtn.Name = "calenderBtn";
            this.calenderBtn.Size = new System.Drawing.Size(220, 42);
            this.calenderBtn.TabIndex = 3;
            this.calenderBtn.Text = "Calender";
            this.calenderBtn.UseVisualStyleBackColor = true;
            this.calenderBtn.Click += new System.EventHandler(this.calenderBtn_Click);
            this.calenderBtn.Leave += new System.EventHandler(this.calenderBtn_Leave);
            // 
            // analyticsBtn
            // 
            this.analyticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.analyticsBtn.FlatAppearance.BorderSize = 0;
            this.analyticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyticsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analyticsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.analyticsBtn.Image = global::Dashboard.Properties.Resources.Analytics_icon;
            this.analyticsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analyticsBtn.Location = new System.Drawing.Point(0, 186);
            this.analyticsBtn.Name = "analyticsBtn";
            this.analyticsBtn.Size = new System.Drawing.Size(220, 42);
            this.analyticsBtn.TabIndex = 2;
            this.analyticsBtn.Text = "Analytics";
            this.analyticsBtn.UseVisualStyleBackColor = true;
            this.analyticsBtn.Click += new System.EventHandler(this.analyticsBtn_Click);
            this.analyticsBtn.Leave += new System.EventHandler(this.analyticsBtn_Leave);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dashboardBtn.Image = global::Dashboard.Properties.Resources.Home_icon;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 144);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(220, 42);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            this.dashboardBtn.Leave += new System.EventHandler(this.dashboardBtn_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.userTxtLbl);
            this.panel2.Controls.Add(this.userLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // userTxtLbl
            // 
            this.userTxtLbl.AutoSize = true;
            this.userTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userTxtLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userTxtLbl.Location = new System.Drawing.Point(64, 129);
            this.userTxtLbl.Name = "userTxtLbl";
            this.userTxtLbl.Size = new System.Drawing.Size(85, 12);
            this.userTxtLbl.TabIndex = 2;
            this.userTxtLbl.Text = "Some User Text";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.userLabel.Location = new System.Drawing.Point(64, 113);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(85, 16);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User Name";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.closeBtn.Location = new System.Drawing.Point(920, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "O";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maximizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.maximizeBtn.Location = new System.Drawing.Point(884, 0);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(30, 30);
            this.maximizeBtn.TabIndex = 1;
            this.maximizeBtn.Text = "■";
            this.maximizeBtn.UseVisualStyleBackColor = true;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.minimizeBtn.Location = new System.Drawing.Point(848, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 30);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.maximizeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.navigationPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.navigationPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button analyticsBtn;
        private System.Windows.Forms.Button calenderBtn;
        private System.Windows.Forms.Button contactBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label userTxtLbl;
        private System.Windows.Forms.Label userLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maximizeBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

