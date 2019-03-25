namespace GUI_placement_managment
{
    partial class studentform
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
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyprofile1 = new GUI_placement_managment.companyprofile();
            this.studentprofile1 = new GUI_placement_managment.studentprofile();
            this.appliedcompany1 = new GUI_placement_managment.appliedcompany();
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
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.studentDetailsToolStripMenuItem.Text = "Profile";
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.saveToolStripMenuItem.Text = "Applied";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "Help?";
            // 
            // companyprofile1
            // 
            this.companyprofile1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.companyprofile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyprofile1.Location = new System.Drawing.Point(0, 24);
            this.companyprofile1.Name = "companyprofile1";
            this.companyprofile1.Size = new System.Drawing.Size(843, 451);
            this.companyprofile1.TabIndex = 10;
            this.companyprofile1.Visible = false;
            // 
            // studentprofile1
            // 
            this.studentprofile1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.studentprofile1.Location = new System.Drawing.Point(0, 27);
            this.studentprofile1.Name = "studentprofile1";
            this.studentprofile1.Size = new System.Drawing.Size(843, 451);
            this.studentprofile1.TabIndex = 9;
            this.studentprofile1.Visible = false;
            // 
            // appliedcompany1
            // 
            this.appliedcompany1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.appliedcompany1.Location = new System.Drawing.Point(0, 27);
            this.appliedcompany1.Name = "appliedcompany1";
            this.appliedcompany1.Size = new System.Drawing.Size(843, 448);
            this.appliedcompany1.TabIndex = 11;
            this.appliedcompany1.Visible = false;
            // 
            // studentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 475);
            this.Controls.Add(this.appliedcompany1);
            this.Controls.Add(this.companyprofile1);
            this.Controls.Add(this.studentprofile1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "studentform";
            this.Text = "studentform";
            this.Load += new System.EventHandler(this.studentform_Load);
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private studentprofile studentprofile1;
        private companyprofile companyprofile1;
        private appliedcompany appliedcompany1;
    }
}