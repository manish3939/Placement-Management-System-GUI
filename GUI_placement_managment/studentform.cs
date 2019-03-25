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
    public partial class studentform : Form
    {
        public studentform()
        {
            InitializeComponent();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentprofile1.Visible = true;
        }

        private void studentform_Load(object sender, EventArgs e)
        {

        }

        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentprofile1.Visible = false;
            companyprofile1.Visible = true;
          
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentprofile1.Visible = false;
            companyprofile1.Visible = false;
            appliedcompany1.Visible = true;
        }
    }
}
