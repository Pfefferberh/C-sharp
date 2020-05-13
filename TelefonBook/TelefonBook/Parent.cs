using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TelefonBook
{
    public partial class Parent : Form
    {

        List<Man> listman = new List<Man>();
        public Parent()
        {
            InitializeComponent();
            AddsDataSource(ref listman);
        }
        private void AddsDataSource(ref List<Man> listman)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = null;
            listBox1.DataSource = listman;
            listBox1.DisplayMember = "Show";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.ShowDialog();
            listman.Add(child.man);

            AddsDataSource(ref listman);
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Child child = new Child();
                child.textBoxName.Text = listman[listBox1.SelectedIndex].Name;
                child.textBoxNumb.Text = listman[listBox1.SelectedIndex].Number;
                child.pictureBoxLoadF.Image = listman[listBox1.SelectedIndex].Fotka;
                child.ShowDialog();
                if (child.exit)
                {
                    listman.RemoveAt(listBox1.SelectedIndex);
                    listman.Insert(listBox1.SelectedIndex, child.man);
                }

                AddsDataSource(ref listman);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                pictureBoxFoto.Image = listman[listBox1.SelectedIndex].Fotka;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listman.RemoveAt(listBox1.SelectedIndex);
                pictureBoxFoto.Image = null;
                AddsDataSource(ref listman);
            }
        }
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            listman.Clear();
            pictureBoxFoto.Image = null;
            AddsDataSource(ref listman);
        }
    }
}
