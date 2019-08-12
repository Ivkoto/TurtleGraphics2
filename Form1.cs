using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace TurtleGraphics2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
                        
            Turtle.Delay = 300;

            for (int i = 0; i <= 3; i++)
            {
                // Draw a equilateral triangle
                Turtle.Rotate(30);
                Turtle.Forward(200);
                Turtle.Rotate(120);
                Turtle.Forward(200);
                Turtle.Rotate(120);
                Turtle.Forward(200);

                // Draw a line in the triangle
                Turtle.Rotate(-30);
                Turtle.PenUp();
                Turtle.Backward(50);
                Turtle.PenDown();
                Turtle.Backward(100);
                Turtle.PenUp();
                Turtle.Forward(150);
                Turtle.PenDown();
                Turtle.Rotate(30);
            }            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonHide.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonHide.Text = "Hide Turtle";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 300;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 300;
            Turtle.PenColor = Color.Green;

            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            
            Turtle.Delay = 300;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(60);                
            }
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 300;
            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(250);
                Turtle.Rotate(170);
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 300;
            Turtle.PenColor = Color.Red;

            for (int i = 0; i < 3; i++)
            {
                for (int s = 0; s < 22; s++)
                {
                    Turtle.Forward(s * 10);
                    Turtle.Rotate(120);
                }
            }
            
        }
    }
}
