//Nathan Hood, September 29, 2016
//This program is a digital card with a constellation
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            Pen bluePen = new Pen(Color.Blue, 3);
            Pen whitePen = new Pen(Color.White, 3);
            Pen purplePen = new Pen(Color.Purple, 3);
            Pen redPen = new Pen(Color.Red, 3);
            Pen yellowPen = new Pen(Color.Red, 3);

            formGraphics.Clear(Color.Black);
            formGraphics.FillEllipse(whiteBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 234, 256, 10, 10);
            Thread.Sleep(200);
            int number = 3;
            for (int i = 0; i < number; i++)
            {

                formGraphics.DrawLine(whitePen, 243, 210, 565, 190);
                formGraphics.DrawLine(whitePen, 565, 190, 239, 261);
                formGraphics.DrawLine(whitePen, 239, 261, 243, 210);
                Thread.Sleep(200);
                formGraphics.DrawLine(bluePen, 243, 210, 565, 190);
                formGraphics.DrawLine(bluePen, 565, 190, 239, 261);
                formGraphics.DrawLine(bluePen, 239, 261, 243, 210);
                Thread.Sleep(200);
                formGraphics.DrawLine(redPen, 243, 210, 565, 190);
                formGraphics.DrawLine(redPen, 565, 190, 239, 261);
                formGraphics.DrawLine(redPen, 239, 261, 243, 210);
                Thread.Sleep(200);
                formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
                formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);
                formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
                Thread.Sleep(200);
            }

            


        }
    }
}
