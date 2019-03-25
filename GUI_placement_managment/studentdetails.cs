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
    public partial class studentdetails : UserControl
    {
        public studentdetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           sidepanel.Height = button1.Height;
                    sidepanel.Top = button1.Top;
                   // studentpanel.Visible = true;
           

            
           if (string.IsNullOrWhiteSpace(textBox6.Text))
            {

                MessageBox.Show("Please Fill all the Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
             }
           


        }


        private void updatepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            studentpanel.Visible = true;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            studentpanel.Visible = true;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            studentpanel.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                   }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
