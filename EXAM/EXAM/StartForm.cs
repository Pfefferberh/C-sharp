using System;
using System.IO;
using System.Windows.Forms;

namespace EXAM
{
    public partial class StartForm : Form
    {
        TEst childTEstForm = new TEst();
        string path;

        public StartForm()
        {
            InitializeComponent();
        }
        private void Open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Qwestion qwest = new Qwestion();

                path = openFileDialog1.FileName;
                var arrStr = File.ReadAllLines(path);
                foreach (var lineStr in arrStr)
                {
                    if (!string.IsNullOrWhiteSpace(lineStr))
                    {
                        if (lineStr.Substring(lineStr.Length - 1) != "0" && lineStr.Substring(lineStr.Length - 1) != "1")
                            qwest.Text = lineStr;
                        else
                            qwest.qwest.Add(lineStr);
                    }
                    else
                    {
                        childTEstForm.listqwest.Add(qwest);
                        qwest = new Qwestion();
                    }
                }
                childTEstForm.listqwest.Add(qwest);
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Open();
            childTEstForm.LoadQwestWind(childTEstForm.listqwest, childTEstForm, 0);
            childTEstForm.ShowDialog();
        }
    }
}
