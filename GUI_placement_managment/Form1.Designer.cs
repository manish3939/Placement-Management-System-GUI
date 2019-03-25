namespace GUI_placement_managment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.ComboBox();
            this.companydetails1 = new GUI_placement_managment.companydetails();
            this.studentdetails1 = new GUI_placement_managment.studentdetails();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailsToolStripMenuItem,
            this.companyDetailsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // companyDetailsToolStripMenuItem
            // 
            this.companyDetailsToolStripMenuItem.Name = "companyDetailsToolStripMenuItem";
            this.companyDetailsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.companyDetailsToolStripMenuItem.Text = "Company Details";
            this.companyDetailsToolStripMenuItem.Click += new System.EventHandler(this.companyDetailsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "Help?";
            // 
            // Admin
            // 
            this.Admin.AccessibleDescription = "";
            this.Admin.AccessibleName = "";
            this.Admin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Admin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Admin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.FormattingEnabled = true;
            this.Admin.Items.AddRange(new object[] {
            "Logout",
            "Exit"});
            this.Admin.Location = new System.Drawing.Point(697, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(121, 25);
            this.Admin.TabIndex = 8;
            // 
            // companydetails1
            // 
            this.companydetails1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.companydetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companydetails1.Location = new System.Drawing.Point(0, 24);
            this.companydetails1.Name = "companydetails1";
            this.companydetails1.Size = new System.Drawing.Size(843, 451);
            this.companydetails1.TabIndex = 10;
            this.companydetails1.Visible = false;
            // 
            // studentdetails1
            // 
            this.studentdetails1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.studentdetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentdetails1.Location = new System.Drawing.Point(0, 24);
            this.studentdetails1.Name = "studentdetails1";
            this.studentdetails1.Size = new System.Drawing.Size(843, 451);
            this.studentdetails1.TabIndex = 9;
            this.studentdetails1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(843, 475);
            this.Controls.Add(this.companydetails1);
            this.Controls.Add(this.studentdetails1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ComboBox Admin;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private studentdetails studentdetails1;
        private companydetails companydetails1;
    }
}

