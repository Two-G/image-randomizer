using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //counting the files in the "images" root
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo("../../../images");
            //get the count in the variable "counter"
            int counter = dir.GetFiles().Length;
            //generate the random number (max=counter)
            Random rnd = new Random();
            int casual = (rnd.Next(0, counter))+1;

            //change label text
            label1.Text = "File number:" + casual;
            //change the image in the picture Box
            pictureBox1.Image = Image.FromFile("../../../images/" + casual + ".png");
        }
    }
}
