using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_placement_managment
{
    public partial class studentprofile : UserControl
    {
        public studentprofile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
          //  if (string.IsNullOrWhiteSpace(this.textBox6.Text))
            //{
               // MessageBox.Show(textBox6+"is empty");
         //   }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
        }

        private void back_Click(object sender, EventArgs e)
        {

        }


    }
}
