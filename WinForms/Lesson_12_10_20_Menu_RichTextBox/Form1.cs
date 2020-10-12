using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_12_10_20_Menu_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Font font = new Font(richTextBox1.Font.FontFamily, 24);
            //richTextBox1.ForeColor = Color.Red;
            richTextBox1.Font = font;
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = dialog.Color;
            }
        }
    }
}
