using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZS
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> gas = new Dictionary<string, double>();
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
           
        }
  
    }
}
