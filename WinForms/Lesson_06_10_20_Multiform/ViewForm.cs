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
    public partial class ViewForm : Form
    {
        public ViewForm(Person person)
        {
            InitializeComponent();
            nameLabel.Text = person.Name;
            surnameLabel.Text = person.Surname;
            numberTextBox.Text = person.Number;
            emailTextBox.Text = person.Email;
            genderLabel.Text = person.Gender.ToString();
            infoLabel.Text = person.DateOfBirth.ToShortDateString();
            favoriteLabel.Visible = person.Favorite;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
