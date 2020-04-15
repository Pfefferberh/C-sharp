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
//Створити програму "Планування подій(справ)"(Version 1.0).
//На головній формі розмістити
// 	- текстове поле для введення назви події(справи), обов'язкове поле
//	- текстове поле для місця події(не обов'язкове)
//	- DateTimePicker або MonthCalendar для вибору дати події(по замовчуванню на завтра)
//	- текстове поле для вибору пріоритут події(встановити властивість для можливості автозаповнення :
//    високий, середній, низький), по замовчуванню - середній
//	- кнопку Додати, що додає відповідну подію у  статичний текст(чи ListBox: listbox1.Items.Add() - доповнення списку listbox1)
//	- кнопку очищення списку подій
//	- кнопку збереження плану подій у текстовому(xml чи json) файлі(з назвою, що містить поточну дату).
//Зауваження.Не дозволяти планування на "вчора"
//При розв"язуванні задачі визначити клас Подія(Event) з полями назва, дата-час, пріоритет, місце події.
//Визначити також клас для серіалізації(десеріалізації) списку подій.

namespace PlanedTasks
{
    public partial class Form1 : Form
    {
        List<Ivent> ivents = new List<Ivent>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addIvent_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Add(ivent.Text);
            listBoxItem.Items.Add(placeIvent.Text);
            listBoxItem.Items.Add(important.Text);
        }

        private void clearItem_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Remove(ivent.Text);
            listBoxItem.Items.Remove(placeIvent.Text);
            listBoxItem.Items.Remove(important.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Ivent temp = new Ivent();
            temp.name = ivent.Text;
            temp.place = placeIvent.Text;
            temp.impot = important.Text;
            temp.date = dateTimePicker1.Value;
            ivents.Add(temp);
            save_to_xml();
        }

        private void ivent_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ivent.Text == "") 
                this.ivent.Text = "Name ivent";

            if (this.important.Text == "")
                this.important.Text = "midlle";

            if (this.placeIvent.Text == "")
                this.placeIvent.Text = "Place ivent";        
        }

        private void ivent_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as TextBox).Text = "";
        }
        private void save_to_xml()
        {
            string file = dateTimePicker1.Value.ToShortDateString() + ".xml";
            XmlSerializer xml = new XmlSerializer(ivents.GetType()); 
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, ivents);
            }
            MessageBox.Show("Completed!");
        }
    }
}
