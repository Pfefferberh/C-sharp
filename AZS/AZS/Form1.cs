using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AZS
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> gas = new Dictionary<string, double>();
        int Hotdg = 0;
        int Gamb = 0;
        int FriPot = 0;
        int Cola = 0;
        int i = 0;
        double AllSumm = 0;
        public Form1()
        {
            InitializeComponent();
            gas.Add("A-76", 13.5);
            gas.Add("A-95", 20.4);
            cbGas.Items.AddRange(gas.Keys.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbGas.Text = cbGas.Items[0].ToString();
            tbCoastCola.Text = "25";
            tbCoastGam.Text = "15";
            tbCoastHdog.Text = "10";
            tbCoastPot.Text = "13";
            lbSumaMC.Text = "0";
        }

        private void cbGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var dict in gas)
                if (cbGas.SelectedItem.ToString() == dict.Key)
                {
                    tbCoastGas.Text = dict.Value.ToString();
                    lbSumaGS.Text = dict.Value.ToString();
                }
        }
        private void rbLiters_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLiters.Checked == true)
            {
                tbLiters.ReadOnly = false;
                tbSuma.ReadOnly = true;
                tbSuma.Text = "";
            }
        }
        private void rbSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuma.Checked == true)
            {
                tbSuma.ReadOnly = false;
                tbLiters.ReadOnly = true;
                tbLiters.Text = "";
            }
        }

        private void tbLiters_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbLiters.Text))
                lbSumaGS.Text = tbCoastGas.Text;
            else
                lbSumaGS.Text = (Convert.ToDouble(tbLiters.Text) * Convert.ToDouble(tbCoastGas.Text)).ToString();
        }

        private void tbSuma_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSuma.Text))
                lbSumaGS.Text = tbCoastGas.Text;
            else
                lbSumaGS.Text = tbSuma.Text;
        }

        private void cbHotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHotdog.Checked)
            {
                numericUpDownHotdog.ReadOnly = false;
                Hotdg = Convert.ToInt32(tbCoastHdog.Text) * Convert.ToInt32(numericUpDownHotdog.Value);
            }
            else
            {
                numericUpDownHotdog.ReadOnly = true;
                Hotdg = 0;
            }
            ResalFoods();
        }
        private void cbGamb_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGamb.Checked)
            {
                numericUpDownGamb.ReadOnly = false;
                Gamb = Convert.ToInt32(tbCoastGam.Text) * Convert.ToInt32(numericUpDownGamb.Value);
            }
            else
            {
                numericUpDownGamb.ReadOnly = true;
                Gamb = 0;
            }
            ResalFoods();
        }

        private void cbFriPotato_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFriPotato.Checked)
            {
                numericUpDownFriPotato.ReadOnly = false;
                FriPot = Convert.ToInt32(tbCoastPot.Text) * Convert.ToInt32(numericUpDownFriPotato.Value);
            }
            else
            {
                numericUpDownFriPotato.ReadOnly = true;
                FriPot = 0;
            }
            ResalFoods();
        }

        private void cbCola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCola.Checked)
            {
                numericUpDownCola.ReadOnly = false;
                Cola = Convert.ToInt32(tbCoastCola.Text) * Convert.ToInt32(numericUpDownCola.Value);
            }
            else
            {
                numericUpDownCola.ReadOnly = true;
                Cola = 0;
            }
            ResalFoods();
        }
        private void ResalFoods()
        {
            lbSumaMC.Text = (Hotdg + Gamb + FriPot + Cola).ToString();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cbHotdog_CheckedChanged(null, null);
            cbGamb_CheckedChanged(null, null);
            cbFriPotato_CheckedChanged(null, null);
            cbCola_CheckedChanged(null, null);
            ResalFoods();
        }

        private void forPayAll_Click(object sender, EventArgs e)
        {
            lbSumaALL.Text = (Convert.ToDouble(lbSumaMC.Text) + Convert.ToDouble(lbSumaGS.Text)).ToString();
            AllSumm += Convert.ToDouble(lbSumaALL.Text);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 10)
            {
                timer1.Stop();
                MessageBox.Show("Contine?", "Clear", MessageBoxButtons.OKCancel);
                timer1.Start();
            }
            if (DialogResult == DialogResult.OK)
            {
                Clearrrrr();
                timer1.Stop();
                i = 0;
            }
            else if (i == 20)
            {
                Clearrrrr();
            }
        }
        private void Clearrrrr()
        {
            numericUpDownHotdog.Value = 0;
            numericUpDownCola.Value = 0;
            numericUpDownGamb.Value = 0;
            numericUpDownFriPotato.Value = 0;
            tbLiters.Text = "";
            tbSuma.Text = "";
            cbGamb.Checked = false;
            cbCola.Checked = false;
            cbHotdog.Checked = false;
            cbFriPotato.Checked = false;
            rbLiters.Checked = false;
            rbSuma.Checked = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Resault: {AllSumm}", "All Resault");
        }
    }
}
