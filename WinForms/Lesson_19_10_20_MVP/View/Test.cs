using Lesson_19_10_20_MVP.Model;
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
    public partial class Test : Form,IToDoList
    {
        public Test()
        {
            InitializeComponent();
        }

        public event Action Add;
        public event Action<string> Remove;

        public void UpdateList(IEnumerable<ToDo> list)
        {
            elementListView.Items.Clear();
            foreach (var item in list)
            {
                var element = new ListViewItem(item.Task, 0);
                element.Tag = item;
                elementListView.Items.Add(element);
            }
        }

        private void elementListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (elementListView.SelectedItems.Count != 0)
                {
                    foreach (ListViewItem item in elementListView.SelectedItems)
                    {
                        var id = (item.Tag as ToDo).Id;
                        Remove?.Invoke(id);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
        }
    }
}
