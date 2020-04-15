using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int s = 0;
        int x = 0;
        int y = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = ++s + " s";
            Point point = lbltimer.Location;
            lbltimer.Location = new Point(x += 10, y);


        }
    }
}
