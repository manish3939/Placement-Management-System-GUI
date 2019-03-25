namespace GUI_placement_managment
{
    partial class companyform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CompanyProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studdetails1 = new GUI_placement_managment.studdetails();
            this.compprofile1 = new GUI_placement_managment.compprofile();
            this.requests1 = new GUI_placement_managment.requests();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompanyProfileToolStripMenuItem,
            this.StudentDetailsToolStripMenuItem,
            this.RequestToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CompanyProfileToolStripMenuItem
            // 
            this.CompanyProfileToolStripMenuItem.Name = "CompanyProfileToolStripMenuItem";
            this.CompanyProfileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.CompanyProfileToolStripMenuItem.Text = "Profile";
            this.CompanyProfileToolStripMenuItem.Click += new System.EventHandler(this.CompanyProfileToolStripMenuItem_Click);
            // 
            // StudentDetailsToolStripMenuItem
            // 
            this.StudentDetailsToolStripMenuItem.Name = "StudentDetailsToolStripMenuItem";
            this.StudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.StudentDetailsToolStripMenuItem.Text = "Student Details";
            this.StudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.StudentDetailsToolStripMenuItem_Click);
            // 
            // RequestToolStripMenuItem
            // 
            this.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem";
            this.RequestToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.RequestToolStripMenuItem.Text = "Request";
            this.RequestToolStripMenuItem.Click += new System.EventHandler(this.RequestToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "Help?";
            // 
            // studdetails1
            // 
            this.studdetails1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.studdetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studdetails1.Location = new System.Drawing.Point(0, 24);
            this.studdetails1.Name = "studdetails1";
            this.studdetails1.Size = new System.Drawing.Size(833, 440);
            this.studdetails1.TabIndex = 10;
            this.studdetails1.Visible = false;
            // 
            // compprofile1
            // 
            this.compprofile1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.compprofile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compprofile1.Location = new System.Drawing.Point(0, 24);
            this.compprofile1.Name = "compprofile1";
            this.compprofile1.Size = new System.Drawing.Size(833, 440);
            this.compprofile1.TabIndex = 9;
            this.compprofile1.Visible = false;
            // 
            // requests1
            // 
            this.requests1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.requests1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requests1.Location = new System.Drawing.Point(0, 24);
            this.requests1.Name = "requests1";
            this.requests1.Size = new System.Drawing.Size(833, 440);
            this.requests1.TabIndex = 11;
            this.requests1.Visible = false;
            // 
            // companyform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 464);
            this.Controls.Add(this.requests1);
            this.Controls.Add(this.studdetails1);
            this.Controls.Add(this.compprofile1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "companyform";
            this.Text = "companyform";
            this.Load += new System.EventHandler(this.companyform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CompanyProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private compprofile compprofile1;
        private studdetails studdetails1;
        private requests requests1;
    }
}