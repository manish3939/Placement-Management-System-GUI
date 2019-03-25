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
    public partial class Form1 : Form
    {
        private object studentpanel;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentdetails1.Visible = true;



        }

        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentdetails1.Visible = false;
            companydetails1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  companyform cmpform = new companyform();
            //cmpform.Show();
         //  studentform stdform = new studentform();
           // stdform.Show();

        }
    }
}
