using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
//Написати програму, яка веде підрахунок кліків лівою, правою, середньою кнопками по формі.
//Статистику виводити в заголовок форми.На формі зробити кнопку "Очищення статистики", яка після кліку онуляє рахунок кліків.

namespace HW_3_mini_task_
{
    class Program
    {
        static int left = 0;
        static int right = 0;
        static int middle = 0;

        static void Main(string[] args)
        {
            Form form = new Form();
            form.Size = new Size(400,400);
            form.MouseClick += Form_MouseClick;

            Button button = new Button();
            button.Text = "clear";
         
            button.Location=new Point(form.PreferredSize.Width, form.PreferredSize.Height);
            button.MouseClick += Button_MouseClick;

            form.Controls.Add(button);
            form.ShowDialog();
        }

        private static void Button_MouseClick(object sender, MouseEventArgs e)
        {
            left = 0;
            right = 0;
            middle = 0;
        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            Form temp = sender as Form;
            if (e.Button.ToString() == "Left")
                left++;
            else if (e.Button.ToString() == "Right")
                right++;
            else if(e.Button.ToString() == "Middle")
                middle++;
            temp.Text = e.Button.ToString()+ "    left: " +left + "  middle:" + middle+ "  right:" + right;
        }
    }
}
