using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

//Написати програму, яка міститиме дві кнопки: Increase Opacity, Decrease Opacity
//Перша при клікові буде збільшувати прозорість форми, друга - зменшувати

namespace WF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Form form = new Form();
            //form.Size = new Size(400,200);
            //form.Opacity = 1;
            //Button button1 = new Button();
            //button1.Top = 100;
            //button1.Left = 100;
            //button1.Text = "Increase Opacity";
            //button1.Size = new Size(100, 40);
            //button1.MouseClick += Button_MouseClick_but1;

            //Button button2 = new Button();
            //button2.Top = 100;
            //button2.Left = 200;
            //button2.Text = "Decrease Opacity";
            //button2.Size = new Size(100, 40);
            //button2.MouseClick += Button_MouseClick_but2;

            //form.Controls.Add(button1);
            //form.Controls.Add(button2);
            //form.ShowDialog();


            //   Написати програму "Впіймай кнопку".
            //       Кнопка при наведенні на неї курсора мишки буде міняти свою позицію на рандомну.
            //       Якщо користувач "спіймає" кнопку, програма має 
            //       відобразити вікно привітання(MessageBox)
            Form form = new Form();
            int x = 300, y = 300;
            form.Size = new Size(700, 700);
            Button button = new Button();
            button.Top = x;
            button.Left = y;
            Random random = new Random();
            if ( Cursor.Position.X== button. && y == Cursor.Position.Y)
            {
                button.Top = random.Next(700);
                button.Left = random.Next(700);

            }
            else
            {
                button.MouseClick += Button_MouseClick;
            }
            //button.MouseClick += Button_MouseClick;

            form.Controls.Add(button);
            form.ShowDialog();
        }

        private static void Button_MouseClick(object sender, MouseEventArgs e)
        {
            Form temp  = (sender as Button).Parent as Form;
           
                DialogResult dialog = MessageBox.Show("You WIN!!!");
          
        }

        private static void Button_MouseClick_but1(object sender, MouseEventArgs e)
        {
            Form temp = (sender as Button).Parent as Form;
            temp.Opacity-=0.1;
        }
        private static void Button_MouseClick_but2(object sender, MouseEventArgs e)
        {
            Form temp = (sender as Button).Parent as Form;
            temp.Opacity += 0.1;
        }
    }
}
