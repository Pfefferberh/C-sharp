using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Написати програму, яка з кожним кліком по формі буде змінювати фон форми на кольори веселки(і так циклічно)
namespace task2
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.MouseClick += Form_MouseClick;

            form.ShowDialog();
        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            Form temp = sender as Form; 
            switch (counter)
            {
                case 0: temp.BackColor = Color.Red;
                    break;
                case 1: temp.BackColor = Color.Orange;
                    break;
                case 2:
                    temp.BackColor = Color.Yellow;
                    break;
                case 3:
                    temp.BackColor = Color.Green;
                    break;
                case 4:
                    temp.BackColor = Color.Blue;
                    break;
                case 5:
                    temp.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    temp.BackColor = Color.Purple;
                    break;
                default:
                    temp.BackColor = Color.Red;
                    counter = 0;
                    break;
            }
            counter++;
        }
    }
}
