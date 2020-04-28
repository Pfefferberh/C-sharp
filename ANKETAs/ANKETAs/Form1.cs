using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ANKETAs
{
    public partial class Anketa : Form
    {
        users_list peopleList = new users_list();
        List<string> leng = new List<string>();
        string gender = "";
        public Anketa()
        {
            InitializeComponent();
        }

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxName.Text == "Name")
                textBoxName.Text = "";
            else if (textBoxName.Text == "")
                textBoxName.Text = "Name";
        }

        private void DomainUpDownHobby_SelectedItemChanged(object sender, EventArgs e)
        {
            if (DomainUpDownHobby.Text == "else")
                TextBoxHobby.Visible = true;
            else
                TextBoxHobby.Visible = false;
        }

        private void RadioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonMale.Checked)
            {
                gender = RadioButtonMale.Text;
                PictureBox1.Image = Image.FromFile("../../img/M.png");
            }
        }

        private void RadioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonMale.Checked)
            {
                gender = RadioButtonFemale.Text;
                PictureBox1.Image = Image.FromFile("../../img/F.png");
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            user p = new user
            {
                Name = textBoxName.Text,
                date = DateTimePickerBirth.Value,
                Genger = gender,
                Lang = leng,
                Hobby = DomainUpDownHobby.Text,
                langvuage = CheckBox5.Checked
            };
            peopleList.AddPeop(p);
            peopleList.SaveToXml();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            peopleList.Load();
            textBoxName.Text = peopleList.peoples.Last().Name;
            DateTimePickerBirth.Value= peopleList.peoples.Last().date;
            DomainUpDownHobby.Text = peopleList.peoples.Last().Hobby;
            CheckBox5.Checked = peopleList.peoples.Last().langvuage;
            if (peopleList.peoples.Last().Genger == "Male")
                RadioButtonMale.Checked = true;
            else 
                RadioButtonFemale.Checked = true;

            foreach (var r in peopleList.peoples.Last().Lang) {
                if (r == "C++")
                    CheckBox1.Checked = true;
                 if (r == "C#")
                    CheckBox2.Checked = true;
                 if (r == "Python")
                    CheckBox3.Checked = true;
                  if (r == "Java")
                    CheckBox4.Checked = true;
            }
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox= sender as CheckBox;
            if (checkBox.Checked)
                leng.Add(checkBox.Text);
        }

    }
}
