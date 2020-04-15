using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NubForm_virus_game_
{
    class Alies
    {
       List<Label> buttonOK= new List<Label>();
        Random random = new Random();
        public Alies( )
        {
            for (int i = 0; i < 4; i++)
            {
                Label d = new Label();
                d.Location = new Point(random.Next(600), random.Next(400));
                d.Size = new Size(30, 30);
                d.BackColor = Color.DarkOliveGreen;
                buttonOK.Add(d);
            }
        }
       
        public List<Label> Ret()
        {
            return this.buttonOK;
        }
       
    }
}
