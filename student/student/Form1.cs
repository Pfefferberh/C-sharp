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
using System.Xml.Serialization;
//Анкета:
//
//Поля для вводу Імені, Прізвище, Хобі
//               Комбобокс - для статі
//
//        DateTimePicker - Дата народження
//
//        Label - на лейбу розраховується автоматично вік студента
//
//Кнопка - Зберегти - серіалізує об'єкт Студента в файл
//Кнопка - Завантажити - десеріалізує збереженого студента із файла(Бажано останнього)
//Кнопка - Очистити - очищає всі текстові поля
//Після десеріалізації "розкидати" по елементам керування відповідні дані(Дата народження, на текстбокси ім'я, прізвище, хобі )...
//
//ЗАУВАЖЕННЯ***
//Обов'язково використати клас Student
//
namespace student
{
    public partial class Anketa : Form
    {
        public Anketa()
        {
            InitializeComponent();
        }

        private void Anketa_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.NameStud.Text == "")
                this.NameStud.Text = "Name";
            if (this.Surname.Text == "")
                this.Surname.Text = "Surname";
            if (this.hobby.Text == "")
                this.hobby.Text = "Hobby";
        }

        private void NameStud_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox=sender as TextBox;
            if (textBox.Text == "Name" || textBox.Text == "Surname" || textBox.Text == "Hobby")
            textBox.Text = "";

        }

        private void Save_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.NameStud.Text != "" && this.Surname.Text != "" && this.hobby.Text != "" && this.Sex.Text!="")
            {
                Sudent student = new Sudent
                {
                    NameSt = this.NameStud.Text,
                    Surname = this.Surname.Text,
                    Sex = this.Sex.Text,
                    Birthday = this.Birthday.Value
                };

                string file = Birthday.Value.ToShortDateString() + $"_{student.NameSt}.xml";

                XmlSerializer xml = new XmlSerializer(typeof(Sudent));
                using (Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    xml.Serialize(stream, student);
                }

                MessageBox.Show("Success!", "File was write", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some fill is empty!");
            }
        }

        private void Save_MouseClick(object sender, MouseEventArgs e)
        {
            this.Save_KeyPress(null,null);
        }

      
        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
            int day = DateTime.Today.Day - Birthday.Value.Day;
            int mounth = DateTime.Today.Month - Birthday.Value.Month;
            int year = DateTime.Today.Year - Birthday.Value.Year;
            if (mounth < 0)
            {
                mounth = (DateTime.Today.Month + 12) - Birthday.Value.Month;
                year--;
            }
            if (day < 0)
            {
                mounth--;
                if (mounth <=1)
                day =( DateTime.Today.Day+ DateTime.DaysInMonth(Birthday.Value.Year, 1))- Birthday.Value.Day; 
                else
                day =( DateTime.Today.Day+ DateTime.DaysInMonth(Birthday.Value.Year, mounth ))- Birthday.Value.Day;  
            }
                this.Age.Text = $"Age:\n " +$"{year} years " +$"\n {mounth} month " +$"\n {day} days";
        }

        private void Load_KeyPress(object sender, KeyPressEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string[] memb = Directory.GetFiles(path, "*.xml");
            string temp = "";

            try
            {
                foreach (var item in memb)
                {

                    DateTime dateTime = Convert.ToDateTime(File.GetCreationTimeUtc(item));
                    foreach (var file in memb)
                    {
                        DateTime nextTime = Convert.ToDateTime(File.GetCreationTimeUtc(file));
                        if (dateTime >= nextTime)
                            temp = item;
                    }

                }
                Sudent student;
                XmlSerializer xml = new XmlSerializer(typeof(Sudent));
                using (Stream stream = new FileStream(temp, FileMode.Open, FileAccess.Read))
                {
                    student = (Sudent)xml.Deserialize(stream);

                    this.NameStud.Text = student.NameSt;
                    this.Surname.Text = student.Surname;
                    this.Sex.Text = student.Sex;
                    this.Birthday.Value = student.Birthday;

                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Create a survey", "No profiles found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Loads_MouseClick(object sender, MouseEventArgs e)
        {
            Load_KeyPress(null, null);
        }

        private void NameStud_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = sender as TextBox;
                ComboBox comboBox = sender as ComboBox;
                if (sender.Equals(textBox))
                    SelectNextControl(textBox.GetContainerControl().ActiveControl, true, true, true, true);
                if (sender.Equals(comboBox))
                    SelectNextControl(comboBox.GetContainerControl().ActiveControl, true, true, true, true);
            }         
        }
    }
}
