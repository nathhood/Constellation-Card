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
            Font bigFont = new Font("Times New Roman", 40, FontStyle.Bold); //create a font to use in the code
            Font mediumFont = new Font("Courier", 15, FontStyle.Bold); //create a second font to use int eh code
            Font smallFont = new Font("Courier", 10, FontStyle.Bold); //create a third font to use in the code
            Pen bluePen = new Pen(Color.Blue, 3);
            Pen whitePen = new Pen(Color.White, 3);
            Pen purplePen = new Pen(Color.Purple, 3);
            Pen redPen = new Pen(Color.Red, 3);
            Pen yellowPen = new Pen(Color.Yellow, 3);
            int number = 5;

            formGraphics.DrawString("Triangulum Greeting Card", bigFont, whiteBrush, 50, 40);
            formGraphics.DrawString("Nathan Hood", mediumFont, whiteBrush, 50, 550);
            formGraphics.DrawString("September 29 2016", mediumFont, whiteBrush, 50, 575);
            Thread.Sleep(3000);

            formGraphics.Clear(Color.Black);

            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            Thread.Sleep(200);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);
            Thread.Sleep(200);




            formGraphics.FillEllipse(whiteBrush, 238, 205, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 560, 185, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 234, 256, 10, 10);
            Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 239, 261, 243, 210);
            Thread.Sleep(500);
            formGraphics.DrawLine(whitePen, 243, 210, 565, 190);
            Thread.Sleep(500);
            formGraphics.DrawLine(whitePen, 565, 190, 239, 261);
            Thread.Sleep(500);

            for (int i = 0; i < number; i++)
            {

                
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
                formGraphics.DrawLine(purplePen, 243, 210, 565, 190);
                formGraphics.DrawLine(purplePen, 565, 190, 239, 261);
                formGraphics.DrawLine(purplePen, 239, 261, 243, 210);
                Thread.Sleep(200);

            }

            formGraphics.DrawLine(whitePen, 239, 261, 243, 210);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 243, 210, 565, 190);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 565, 190, 239, 261);
            Thread.Sleep(200);

            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 600, 40);


        }
    }
}
