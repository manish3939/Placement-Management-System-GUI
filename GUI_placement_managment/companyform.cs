using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_placement_managment
{
    public partial class companyform : Form
    {
        public companyform()
        {
            InitializeComponent();
        }

        private void companyform_Load(object sender, EventArgs e)
        {

        }

        private void CompanyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compprofile1.Visible = true;
            studdetails1.Visible = false;
            requests1.Visible = false;
        }

        private void StudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compprofile1.Visible = false;
            studdetails1.Visible = true;
            requests1.Visible = false;
        }

        private void RequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compprofile1.Visible = false;
            studdetails1.Visible = false;
            requests1.Visible = true;
        }
    }
}
