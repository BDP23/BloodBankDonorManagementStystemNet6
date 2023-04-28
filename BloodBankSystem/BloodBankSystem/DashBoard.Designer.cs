namespace BloodBankSystem
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.xuibtnExit = new XanderUI.XUIButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePAtientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuibtnExit
            // 
            this.xuibtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuibtnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuibtnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuibtnExit.ButtonImage")));
            this.xuibtnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.xuibtnExit.ButtonText = "X";
            this.xuibtnExit.ClickBackColor = System.Drawing.Color.Gray;
            this.xuibtnExit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtnExit.CornerRadius = 5;
            this.xuibtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuibtnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtnExit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.xuibtnExit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuibtnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuibtnExit.Location = new System.Drawing.Point(893, 6);
            this.xuibtnExit.Name = "xuibtnExit";
            this.xuibtnExit.Size = new System.Drawing.Size(48, 50);
            this.xuibtnExit.TabIndex = 2;
            this.xuibtnExit.TextColor = System.Drawing.Color.Black;
            this.xuibtnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuibtnExit.Click += new System.EventHandler(this.xuibtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.blockStockToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 68);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonorToolStripMenuItem,
            this.updateDetailsToolStripMenuItem});
            this.donorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donorToolStripMenuItem.Image")));
            this.donorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(102, 64);
            this.donorToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonorToolStripMenuItem
            // 
            this.addNewDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDonorToolStripMenuItem.Image")));
            this.addNewDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            this.addNewDonorToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.addNewDonorToolStripMenuItem.Text = "Add New Donor";
            this.addNewDonorToolStripMenuItem.Click += new System.EventHandler(this.addNewDonorToolStripMenuItem_Click);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateDetailsToolStripMenuItem.Image")));
            this.updateDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.updateDetailsToolStripMenuItem.Text = "Manage Donors";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPatientToolStripMenuItem,
            this.updatePAtientToolStripMenuItem,
            this.deletePatientToolStripMenuItem,
            this.viewPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientToolStripMenuItem.Image")));
            this.patientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(106, 64);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPatientToolStripMenuItem.Image")));
            this.addNewPatientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.addNewPatientToolStripMenuItem.Text = "Add New Patient";
            // 
            // updatePAtientToolStripMenuItem
            // 
            this.updatePAtientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updatePAtientToolStripMenuItem.Image")));
            this.updatePAtientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updatePAtientToolStripMenuItem.Name = "updatePAtientToolStripMenuItem";
            this.updatePAtientToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.updatePAtientToolStripMenuItem.Text = "Update Patient";
            // 
            // deletePatientToolStripMenuItem
            // 
            this.deletePatientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePatientToolStripMenuItem.Image")));
            this.deletePatientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deletePatientToolStripMenuItem.Name = "deletePatientToolStripMenuItem";
            this.deletePatientToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.deletePatientToolStripMenuItem.Text = "Delete Patient";
            // 
            // viewPatientToolStripMenuItem
            // 
            this.viewPatientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewPatientToolStripMenuItem.Image")));
            this.viewPatientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewPatientToolStripMenuItem.Name = "viewPatientToolStripMenuItem";
            this.viewPatientToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.viewPatientToolStripMenuItem.Text = "View Patient";
            // 
            // blockStockToolStripMenuItem
            // 
            this.blockStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem});
            this.blockStockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blockStockToolStripMenuItem.Image")));
            this.blockStockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.blockStockToolStripMenuItem.Name = "blockStockToolStripMenuItem";
            this.blockStockToolStripMenuItem.Size = new System.Drawing.Size(130, 64);
            this.blockStockToolStripMenuItem.Text = "Block Stock";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(122, 64);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 485);
            this.Controls.Add(this.xuibtnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton xuibtnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePAtientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
    }
}