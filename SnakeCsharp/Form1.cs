using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X, y = pictureBox1.Location.Y,x1,y1;
            //tepaga
            if (e.KeyCode.ToString() == "W" && pictureBox1.Location.Y-55 > 0)
            {
                if ((pictureBox2.Location.X != x && pictureBox2.Location.Y != y - 55) ||
                   (pictureBox3.Location.X != x && pictureBox3.Location.Y != y - 55) ||
                   (pictureBox4.Location.X != x && pictureBox4.Location.Y != y - 55))
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 55);
                    x1 = pictureBox2.Location.X;
                    y1 = pictureBox2.Location.Y;
                    pictureBox2.Location = new Point(x, y);
                    x = pictureBox3.Location.X;
                    y = pictureBox3.Location.Y;
                    pictureBox3.Location = new Point(x1, y1);
                    pictureBox4.Location = new Point(x, y);
                }
            }
            //pastga
            if (e.KeyCode.ToString() == "S" && pictureBox1.Location.Y < this.Height - 150) 
            {
                if ((pictureBox2.Location.X != x && pictureBox2.Location.Y != y + 55) ||
                   (pictureBox3.Location.X != x && pictureBox3.Location.Y != y + 55) ||
                   (pictureBox4.Location.X != x && pictureBox4.Location.Y != y + 55))
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 55);
                    x1 = pictureBox2.Location.X;
                    y1 = pictureBox2.Location.Y;
                    pictureBox2.Location = new Point(x, y);
                    x = pictureBox3.Location.X;
                    y = pictureBox3.Location.Y;
                    pictureBox3.Location = new Point(x1, y1);
                    pictureBox4.Location = new Point(x, y);
                }
            }
            //chapga
            if (e.KeyCode.ToString() == "A" && pictureBox1.Location.X-55 > 0)
            {
                if ((pictureBox2.Location.X != x - 55 && pictureBox2.Location.Y != y) ||
                   (pictureBox3.Location.X != x - 55 && pictureBox3.Location.Y != y) ||
                   (pictureBox4.Location.X != x - 55 && pictureBox4.Location.Y != y))
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 55, pictureBox1.Location.Y);
                    x1 = pictureBox2.Location.X;
                    y1 = pictureBox2.Location.Y;
                    pictureBox2.Location = new Point(x, y);
                    x = pictureBox3.Location.X;
                    y = pictureBox3.Location.Y;
                    pictureBox3.Location = new Point(x1, y1);
                    pictureBox4.Location = new Point(x, y);
                }
            }
            //ongga
            if (e.KeyCode.ToString() == "D" && pictureBox1.Location.X+55 < this.Width-55)
            {
                if ((pictureBox2.Location.X != x + 55 && pictureBox2.Location.Y != y) ||
                 (pictureBox3.Location.X != x + 55 && pictureBox3.Location.Y != y) ||
                 (pictureBox4.Location.X != (x + 55) && pictureBox4.Location.Y != y))
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 55, pictureBox1.Location.Y);
                    x1 = pictureBox2.Location.X;
                    y1 = pictureBox2.Location.Y;
                    pictureBox2.Location = new Point(x, y);
                    x = pictureBox3.Location.X;
                    y = pictureBox3.Location.Y;
                    pictureBox3.Location = new Point(x1, y1);
                    pictureBox4.Location = new Point(x, y);
                }
            }
        }
    }
}
