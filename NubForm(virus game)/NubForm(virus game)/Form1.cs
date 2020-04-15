using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NubForm_virus_game_
{
    public partial class Game : Form
    {
        Alies alies = new Alies();
        Point point = new Point();
        Label cick = new Label();
        public Game()
        {
            InitializeComponent();
           
            for(int i=0;i<alies.Ret().Count;i++) {
                this.Controls.Add(alies.Ret()[i]);
            }
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           for (int i = 0; i < alies.Ret().Count; i++)
            {
                Label vir = alies.Ret()[i];
                point.Y = vir.Location.Y;
                point.X = vir.Location.X;

                 if (vir.Location.X > Person.Location.X && vir.Location.Y > Person.Location.Y)
                    vir.Location = new Point(point.X-1, point.Y-1);
                 else if (vir.Location.X > Person.Location.X && vir.Location.Y < Person.Location.Y)
                    vir.Location = new Point(point.X-1, point.Y+1);
                else if (vir.Location.X < Person.Location.X && vir.Location.Y < Person.Location.Y)
                    vir.Location = new Point(point.X + 1, point.Y + 1);
                else if (vir.Location.X < Person.Location.X && vir.Location.Y > Person.Location.Y)
                    vir.Location = new Point(point.X + 1, point.Y - 1);

                if (vir.Location.X > Person.Location.X && vir.Location.Y == Person.Location.Y)
                    vir.Location = new Point(point.X - 1, point.Y );
                else if (vir.Location.X < Person.Location.X && vir.Location.Y == Person.Location.Y)
                    vir.Location = new Point(point.X + 1, point.Y );
                else if (vir.Location.X == Person.Location.X && vir.Location.Y > Person.Location.Y)
                    vir.Location = new Point(point.X, point.Y - 1);
                else if (vir.Location.X == Person.Location.X && vir.Location.Y < Person.Location.Y)
                    vir.Location = new Point(point.X , point.Y + 1);

                if (vir.Location.X == Person.Location.X && vir.Location.Y == Person.Location.Y)
                {
                    Person.Text="You lose";
                    timer1.Stop();
  
                }

           }
            
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

     

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            Person.Location = e.Location;
        }

        private void Person_DoubleClick(object sender, EventArgs e)
        {
            
            cick.Location = new Point(Person.Location.X-5, Person.Location.Y - 5);
            cick.Size =new Size(Person.Width + 10, Person.Height + 10);
            cick.BackColor = Color.Black;
            //Person.BackColor = Color.Azure;
            this.Controls.Add(cick);
           
        }

        private void Person_Move(object sender, EventArgs e)
        {
            this.Controls.Remove(cick);
        }
    }
}
