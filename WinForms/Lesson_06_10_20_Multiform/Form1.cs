using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_06_10_20_Multiform
{
    public partial class MainForm : Form
    {
       
        private List<Person> people;
        public MainForm()
        {
            InitializeComponent();

            people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText("data.json"));
            personListBox.Items.AddRange(people.ToArray());
        }

        private void viewButton_Click(object sender, EventArgs e)
        {

            Person selectedPerson = personListBox.SelectedItem as Person;
            if (selectedPerson != null)
            {
                ViewForm viewForm = new ViewForm(selectedPerson);
                viewForm.ShowDialog();
                //MessageBox.Show($"{selectedPerson.Name} {selectedPerson.Surname}" +
                //    $"\n{selectedPerson.Number}\n{selectedPerson.Email}", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            File.WriteAllText("data.json", JsonConvert.SerializeObject(people));             
            base.OnClosing(e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                people.Add(addForm.Person);
                personListBox.Items.Clear();
                personListBox.Items.AddRange(people.ToArray());
            }

            //Person addedPerson = addForm.ShowDialog();
            //people.Add(addedPerson);
            //personListBox.Items.Add(addedPerson);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = personListBox.SelectedItem as Person;
            if (selectedPerson != null)
            {
                AddForm editForm = new AddForm(selectedPerson);
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var index = personListBox.SelectedIndex;
                    people.RemoveAt(index);
                    people.Insert(index, editForm.Person);
                    personListBox.Items.RemoveAt(index);
                    personListBox.Items.Insert(index, editForm.Person);
                }
            }

        }
    }
}
