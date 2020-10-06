using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_06_10_20_Multiform
{
    public partial class MainForm : Form
    {
       
        private List<Person> people = new List<Person>();
        public MainForm()
        {
            InitializeComponent();
            people.Add(new Person() { Name = "Aftandil", Surname = "Mammadov", DateOfBirth = new DateTime(1982, 1, 12),
                Gender = Gender.Male, Number = "(055)5555555", Email = "afti@gmail.com", Favorite = true });
            people.Add(new Person()
            {
                Name = "Xuraman",
                Surname = "Abbasova",
                DateOfBirth = new DateTime(1990, 11, 19),
                Gender = Gender.Female,
                Number = "(055)5553554",
                Email = "xurush@gmail.com",
                Favorite = false
            });
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
        
  
    }
}
