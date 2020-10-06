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
    public partial class AddForm : Form
    {
        public Person Person { get; private set; }
        public AddForm()
        {
            InitializeComponent();
        }

        //public new Person ShowDialog()
        //{
        //    base.ShowDialog();
        //    return Person;
        //}

        private void addButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = nameTextBox.Text;
            person.Surname = surnameTextBox.Text;
            person.Email = emailTextBox.Text;
            person.Number = numberMaskedTextBox.Text;
            person.DateOfBirth = dateTimePicker.Value;
            if (maleRadioButton.Checked)
            {
                person.Gender = Gender.Male;
            }
            else if (femaleRadioButton.Checked)
            {
                person.Gender = Gender.Female;
            }
            else
            {
                person.Gender = Gender.Other;
            }
            person.Favorite = favoriteCheckBox.Checked;
            Person = person;
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
