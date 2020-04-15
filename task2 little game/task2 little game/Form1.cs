using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2_little_game
{
    public partial class Form1 : Form
    {
        Point point = new Point(0, 0);
        int tim = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = tim++ + "s";
           if (this.label1.Bounds.Right<this.Width-10 && this.label1.Location.Y == 0)
                this.label1.Location = new Point(point.X+=10, point.Y);

            else if(this.label1.Bounds.Right >= this.Width-20 && this.label1.Location.Y < this.Height-90)
                this.label1.Location = new Point(point.X , point.Y+=10);

            else if(this.label1.Location.X > 0 && this.label1.Location.Y <= this.Height-70)
                this.label1.Location = new Point(point.X-=10, point.Y );

            else if(this.label1.Location.X == 0 && this.label1.Location.Y >0)
                this.label1.Location = new Point(point.X , point.Y-=10);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }
    }
}
