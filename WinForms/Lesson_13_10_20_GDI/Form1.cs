using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_13_10_20_GDI
{
    public partial class Form1 : Form
    {
        private Color color;
        private Point oldPoint;
        private int size;
        public Form1()
        {
            InitializeComponent();
            //Timer timer = new Timer();
            //timer.Interval = 1000;
            //timer.Tick += Timer_Tick;
            //timer.Start();
            color = Color.Black;
            ColorChange();
            FormClosing += Form1_FormClosing;
            sizeToolStripButton.Items.AddRange(Enumerable.Range(1, 10).Select(x => x as object).ToArray());
            sizeToolStripButton.SelectedIndex = 4;
            size = 5;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Closed");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Brush brush = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            var graphics = CreateGraphics();
            graphics.FillRectangle(brush, 0, 0, Width , Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Random rand = new Random();
            //Brush brush = new SolidBrush(Color.FromArgb(rand.Next(0,255), rand.Next(0, 255), rand.Next(0, 255)));
            //e.Graphics.FillRectangle(brush, 10, 10, 100, 100);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var graphics = CreateGraphics();
                Brush brush = new SolidBrush(color);
                graphics.FillRectangle(brush, e.X, e.Y, size, size);
               // graphics.DrawLine(new Pen(color),oldPoint, new Point(e.X,e.Y));
            }
        }

        private void colorToolStripButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = dialog.Color;
                ColorChange();
            }
        }

        private void ColorChange()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(color);
            colorToolStripButton.Image = bitmap;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint = new Point(e.X, e.Y);
        }

        private void sizeToolStripButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = (int)sizeToolStripButton.SelectedItem;
        }
    }
}
