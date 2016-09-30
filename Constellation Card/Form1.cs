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
using System.Media;

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
            int number5 = 5; //designate a local variable for the first loop to play 5 times
            int number3 = 3; //designate a local variable for the second loop to play  times
            Graphics formGraphics = this.CreateGraphics(); //Allow fo graphics to be created
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow); //Create a white brush
            SolidBrush whiteBrush = new SolidBrush(Color.White); //create a red brush
            Font bigFont = new Font("Times New Roman", 40, FontStyle.Bold); //create a font to use in the code
            Font mediumFont = new Font("Courier", 15, FontStyle.Bold); //create a second font to use int eh code
            Font smallFont = new Font("Courier", 10, FontStyle.Bold); //create a third font to use in the code
            Pen bluePen = new Pen(Color.Blue, 3); //create the different colours for lines
            Pen whitePen = new Pen(Color.White, 3); //create the different colours for lines
            Pen purplePen = new Pen(Color.Purple, 3); //create the different colours for lines
            Pen redPen = new Pen(Color.Red, 3); //create the different colours for lines
            Pen yellowPen = new Pen(Color.Yellow, 3); //create the different colours for lines
            SoundPlayer ding = new SoundPlayer(Properties.Resources.ding); //to desgnate the sound file to the name ding
            SoundPlayer tada = new SoundPlayer(Properties.Resources.tada); //to designate a different sound file to the name tada
            SoundPlayer organTada = new SoundPlayer(Properties.Resources.organTada); //to desgnate the sound file to the name organTada
            //write the words as soon as the screen is clicked
            formGraphics.DrawString("Triangulum Greeting Card", bigFont, whiteBrush, 50, 40);
            formGraphics.DrawString("Nathan Hood", mediumFont, whiteBrush, 50, 550);
            formGraphics.DrawString("September 29 2016", mediumFont, whiteBrush, 50, 575);
            Thread.Sleep(3000);

            //clear the screen to a black screen
            formGraphics.Clear(Color.Black);

            //draw the smaller stars and pause the program for 200 millisecond between
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
            Thread.Sleep(1000);

            //draw the constellation stars and play the ding sound with each star
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 238, 205, 10, 10);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 560, 185, 10, 10);
            Thread.Sleep(1000);
            ding.Play();
            formGraphics.FillEllipse(whiteBrush, 234, 256, 10, 10);
            Thread.Sleep(1000);

            //connect the constellation stars with lines
            formGraphics.DrawLine(whitePen, 239, 261, 243, 210);
            Thread.Sleep(500);
            formGraphics.DrawLine(whitePen, 243, 210, 565, 190);
            Thread.Sleep(500);
            formGraphics.DrawLine(whitePen, 565, 190, 239, 261);
            Thread.Sleep(500);
            organTada.Play();
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            Thread.Sleep(3000);

            //loop to flash the lines between four different colours
            for (int i = 0; i < number5; i++)
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

            //turn the lines back to white in intervals
            formGraphics.DrawLine(whitePen, 239, 261, 243, 210);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 243, 210, 565, 190);
            Thread.Sleep(200);
            formGraphics.DrawLine(whitePen, 565, 190, 239, 261);
            Thread.Sleep(200);

            //loop for flashing the lines yellow and white
            for (int i = 0; i < number3; i++)
            {
                formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
                formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
                formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);
                Thread.Sleep(200);
                formGraphics.DrawLine(whitePen, 239, 261, 243, 210);
                formGraphics.DrawLine(whitePen, 243, 210, 565, 190);
                formGraphics.DrawLine(whitePen, 565, 190, 239, 261);
                Thread.Sleep(200);
            }

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);
            Thread.Sleep(200);

            //turn the stars to yellow to signify the constellation being finished flashing
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);
            
            //sound to signify the constellation is finished and the words are scrolling up
            tada.Play();

            //create the description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 650);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 680);

            Thread.Sleep(50); //pause the program to make it look like scrolling

            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 640);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 670);


            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50);

            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 630);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 660);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50);

            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 620);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 650);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50); //pause the program
          
            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 610);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 640);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50); //pause the program
            
            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 600);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 630);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50); //pause the program
            
            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 590);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 620);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50); //pause the program
            
            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 580);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 610);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50); //pause the program
           
            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 570);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 600);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50); //pause the program

            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 560);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 590);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);

            Thread.Sleep(50); //pause the program

            formGraphics.Clear(Color.Black); //clear the screen to a black screen

            //create the scrolling description for the star using a different font then the tittle
            formGraphics.DrawString("Triangulum is a small constellation in the northern sky.", smallFont, whiteBrush, 60, 550);
            formGraphics.DrawString("Triangulum was one of the 48 constellations listed by the 2nd century astronomer Ptolemy.", smallFont, whiteBrush, 60, 580);

            //draw the smaller stars
            formGraphics.FillEllipse(whiteBrush, 300, 38, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 500, 58, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 600, 98, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 100, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 850, 452, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 684, 241, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 65, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 486, 602, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 458, 99, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 25, 35, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 578, 64, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 687, 153, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 789, 265, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 348, 648, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 435, 561, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 682, 305, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 598, 530, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 703, 631, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 165, 498, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 231, 496, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 34, 634, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 135, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 206, 364, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 394, 460, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 496, 469, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 500, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 437, 167, 5, 5);

            //draw the constellation stars
            formGraphics.FillEllipse(yellowBrush, 238, 205, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 560, 185, 10, 10);
            formGraphics.FillEllipse(yellowBrush, 234, 256, 10, 10);

            //turn the lines to yellow
            formGraphics.DrawLine(yellowPen, 239, 261, 243, 210);
            formGraphics.DrawLine(yellowPen, 243, 210, 565, 190);
            formGraphics.DrawLine(yellowPen, 565, 190, 239, 261);






        }
    }
}
