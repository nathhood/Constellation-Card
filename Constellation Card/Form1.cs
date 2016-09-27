//Made by Nathan Hood on September 29th
//Made for a greeting card
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellation_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 650);
            BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Allow fo graphics to be created
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow); //Create a white brush
            SolidBrush whiteBrush = new SolidBrush(Color.White); //create a red brush
            Font bigFont = new Font("Times New Roman", 90, FontStyle.Bold); //create a font to use in the code
            Font mediumFont = new Font("Courier", 20, FontStyle.Bold); //create a second font to use int eh code
            Font smallFont = new Font("Courier", 5, FontStyle.Bold); //create a third font to use in the code
            Pen bluePen = new Pen(Color.Blue, 5);

            formGraphics.Clear(Color.Black);

            formGraphics.FillPie(whiteBrush, 238, 205, 10, 10, 25, 360);
            formGraphics.FillPie(whiteBrush, 560, 185, 10, 10, 25, 360);
            formGraphics.FillPie(whiteBrush, 234, 256, 10, 10, 25, 360);



        }
    }
}
