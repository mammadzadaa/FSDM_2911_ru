using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_05_10_20
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                var result = MessageBox.Show("Some text that apear on MS Box","My MS Box",
                                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Yes");
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Console.Beep(2000, 500);
            }
        }

        private void MyForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:{e.X} Y:{e.Y}";
        }
    }
}
