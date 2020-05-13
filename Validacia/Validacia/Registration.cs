using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Validation
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void tbBirth_Validating(object sender, CancelEventArgs e)
        {
            int age = 0;
            if (string.IsNullOrEmpty(tbBirth.Text))
            {
                tbBirth.Text = "0";
                return;
            }
            if (!Int32.TryParse(tbBirth.Text, out age))
                errorProvider.SetError(tbBirth, "Has leters!");
            else
            {
                if (age < 12)
                    errorProvider.SetError(tbBirth, "Minimal age 12!");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var boxes = Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (!String.IsNullOrEmpty(errorProvider.GetError(box)))
                {
                    MessageBox.Show("Error", "Error");
                    return;
                }
            }
            MessageBox.Show("Complite", "Done");
        }
        private void TextValidate(TextBox tb)
        {
            AllValidate(tb);
            string tmp = tb.Text;
            bool findNum = false;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (Char.IsNumber(tmp[i]) == true)
                    findNum = true;
            }
            if (findNum == true)
                errorProvider.SetError(tb, "Fild has number!");
        }
        private void AllValidate(TextBox tb)
        {
            if (String.IsNullOrEmpty(tb.Text))
                errorProvider.SetError(tb, "Fild is empty!");
            else
                errorProvider.Clear();
        }
        private void tbNumber_Validating(object sender, CancelEventArgs e)
        {
            AllValidate(tbNumber);
            if (tbNumber.Text.Length != 10 || tbNumber.Text[0] != '0')
                errorProvider.SetError(tbNumber, "Number not corect! start 0 & 10 numb");
        }
        private void tbName_Validating(object sender, CancelEventArgs e) => TextValidate(tbName);
        private void tbSurname_Validating(object sender, CancelEventArgs e) => TextValidate(tbSurname);
    }
}
