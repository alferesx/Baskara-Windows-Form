using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {

        
        public Form1()
        {
           
            InitializeComponent();
            


        }

        private void calculate_Click(object sender, EventArgs e)
        {

            deltabox.Text =Convert.ToString(int.Parse(bbox.Text) * int.Parse(bbox.Text) - (4 * int.Parse(abox.Text) * int.Parse(cbox.Text)));
            x1.Text = Convert.ToString(((-int.Parse(bbox.Text)) + Math.Sqrt(int.Parse(deltabox.Text))) / (2 * int.Parse(abox.Text)));
            x2.Text = Convert.ToString(((-int.Parse(bbox.Text)) - Math.Sqrt(int.Parse(deltabox.Text))) / (2 * int.Parse(abox.Text)));


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
