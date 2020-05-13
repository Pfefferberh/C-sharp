using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelefonBook
{
    public partial class Child : Form
    {
        public Man man;
        public bool exit = true;
        bool kostul = true;
        public Child()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            man = new Man
            {
                Name = textBoxName.Text,
                Number = textBoxNumb.Text,
                Fotka = pictureBoxLoadF.Image
            };
            kostul = false;
            int Num;
            bool isNum = int.TryParse(textBoxNumb.Text.Trim(), out Num);
            if (string.IsNullOrEmpty(textBoxName.Text))
                errorProvider1.SetError(textBoxName, "Fild is empty");
            else
            {
                if (isNum && Num > 0)
                {
                    man.Number = Num.ToString();
                    this.Close();
                }
                else
                    errorProvider1.SetError(textBoxNumb, "Fild have wrong sing");
            }
        }

        private void buttonChoisFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                pictureBoxLoadF.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kostul)
                exit = false;
        }
    }
}
