using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CityTask
{
    public partial class LookCity : Form
    {
        List<City> towns = new List<City>();
        public LookCity()
        {
            InitializeComponent();
            towns.Add(new City() { Name = "Rivne", Url = "https://uk.wikipedia.org/wiki/%D0%A0%D1%96%D0%B2%D0%BD%D0%B5", image = imageList1 });
            towns.Add(new City() { Name = "Lviv", Url = "https://uk.wikipedia.org/wiki/%D0%9B%D1%8C%D0%B2%D0%BE%D0%B2", image = imageList2 });
        }
        private void LookCity_Load(object sender, EventArgs e)
        {
            foreach (var temp in towns)
                comboBoxCity.Items.Add(temp.Name);

            comboBoxCity.Text = comboBoxCity.Items[0].ToString();
            pictureBoxCity.Image = towns[0].image.Images[0];
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBoxCity.Image = towns[comboBoxCity.SelectedIndex].image.Images[e.NewValue];
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            vScrollBar1.Maximum = towns[comboBoxCity.SelectedIndex].image.Images.Count - 1;
            pictureBoxCity.Image = towns[comboBoxCity.SelectedIndex].image.Images[0];
            vScrollBar1.Value = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(towns[comboBoxCity.SelectedIndex].Url);
        }
    }
}
