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
    public partial class AddForm : Form
    {
        private enum Type
        {
            Add, Edit
        }
        private Type type;
        private string imagePath = null;
        public Person Person { get; private set; }
        public AddForm()
        {
            InitializeComponent();
            type = Type.Add;
        }
        public AddForm(Person person)
        { 
            InitializeComponent();
            Person = person;
            this.addButton.Text = "Save";
            type = Type.Edit;
            nameTextBox.Text = person.Name;
            surnameTextBox.Text = person.Surname;
            emailTextBox.Text = person.Email;
            numberMaskedTextBox.Text = person.Number;
            dateTimePicker.Value = person.DateOfBirth;
            favoriteCheckBox.Checked = person.Favorite;
            switch (person.Gender)
            {
                case Gender.Male:
                    maleRadioButton.Checked = true;
                    break;
                case Gender.Female:
                    femaleRadioButton.Checked = true;
                    break;
                case Gender.Other:
                    otherRadioButton.Checked = true;
                    break;
            }
            pictureBox.Image = Image.FromFile(person.Image);
        }

        //public new Person ShowDialog()
        //{
        //    base.ShowDialog();
        //    return Person;
        //}

        private string UploadAndGetNewPath(string oldPath)
        {
            string newPath = null;
            
            try
            {               
                var directory = Directory.GetCurrentDirectory();
                if (!Directory.Exists($@"{directory}\Photos"))
                {
                    Directory.CreateDirectory($@"{directory}\Photos");
                }
                if (oldPath == null)
                {
                    newPath = $@"{directory}\Photos\default_image.png";
                }
                else
                {
                    var extention = Path.GetExtension(oldPath);
                    newPath = $@"{directory}\Photos\{Guid.NewGuid()}{extention}";
                    File.Copy(oldPath, newPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
                return newPath;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
    
            person.Name = nameTextBox.Text;
            person.Surname = surnameTextBox.Text;
            person.Email = emailTextBox.Text;
            person.Number = numberMaskedTextBox.Text;
            person.DateOfBirth = dateTimePicker.Value;
            person.Image = UploadAndGetNewPath(imagePath);
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

        private void uploadButton_Click(object sender, EventArgs e)
        {
            var dialoge = new OpenFileDialog();
            dialoge.Filter = "Image (*.png,*.jpg ) | *.jpg;*.png";
            var result = dialoge.ShowDialog();
            if (result == DialogResult.OK)
            {
                imagePath = dialoge.FileName;
                pictureBox.Image = Image.FromFile(imagePath);
            }

        }
    }
}
