using Lesson_19_10_20_MVP.Model;
using Lesson_19_10_20_MVP.Presenter;
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
    public partial class ToDoList : Form, IToDoList
    {
        public event Action Add;
        public event Action<string> Remove;

        public ToDoList()
        {     
            InitializeComponent();
        }
        public void UpdateList(IEnumerable<ToDo> list)
        {
            toDoListBox.Items.Clear();
            toDoListBox.Items.AddRange(list.ToArray());
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var item = toDoListBox.SelectedItem as ToDo;
            if (item != null)
            {
                Remove?.Invoke(item.Id);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
        }

        private void toDoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = toDoListBox.SelectedItem as ToDo;
            if (item != null)
            {
                descriptionTextBox.Text = item.Description;
            }
        }
    }
}
