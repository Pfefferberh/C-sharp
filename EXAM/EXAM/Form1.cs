using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EXAM
{
    public partial class TEst : Form
    {
        public List<Qwestion> listqwest = new List<Qwestion>();
        int i = 1;
        int Mark = 0;
        int checkTrue = 0;
        int checkFalse = 0;
        public TEst()
        {
            InitializeComponent();
        }
        private void TryIfTrue()
        {
            int index = 0;
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                index = checkedListBox1.Items.IndexOf(itemChecked);
                if (listqwest[i - 1].qwest[index] == itemChecked.ToString() + "1")
                    if (listqwest[i - 1].tryest[index] == 1)
                        checkTrue++;
                if (listqwest[i - 1].qwest[index] == itemChecked.ToString() + "0")
                    checkFalse++;
            }
        }
        public void LoadQwestWind(List<Qwestion> qwestions, TEst form,int inde)
        {
            form.label1.Text = qwestions[inde].Text;
            foreach (var tem in qwestions[inde].qwest)
            {
                form.checkedListBox1.Items.Add(tem.Substring(0, tem.Length - 1));
                if (int.Parse(tem.Substring(tem.Length - 1)) == 1)
                    qwestions[inde].tryest.Add(1);
                else
                    qwestions[inde].tryest.Add(0);
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (listqwest.Count > i)
            {
                TryIfTrue();
                checkedListBox1.Items.Clear();
                LoadQwestWind(listqwest, this,i);
                 i++;
            }
            else
            {
                buttonNext.Visible = false;
                buttonCheck.Visible = true;
            }
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            TryIfTrue();
            if (checkTrue <= checkFalse)
                Mark = 0;
            else
                Mark = checkTrue - checkFalse;

            label1.Text = "Your resaul :  true " + checkTrue.ToString() + "             false " + checkFalse.ToString()+ $"\nYour mark :  {Mark}";
        }
    }
}
