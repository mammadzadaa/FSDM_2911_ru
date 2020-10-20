using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_19_10_20_MVP.View
{
    public partial class AddForm : Form, IAddTaskView
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public string Title {   get => titleTextBox.Text; }
        public string Description { get => descriptionTextBox.Text; }

        public event Action Add;

        private void addButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
