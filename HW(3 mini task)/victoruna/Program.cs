using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
//Створити програму Вікторина(Тестування). Програма задає декілька питань користувачу, очікуючи відповіді типу Так-Ні.
//Програма видає результат проходження вікторини(тесту) :
//кількість правильних та загальне число відповідей(н-д, "правильних відповідей 2, всього питань  5")
//* Бажано створення класів
//Питання(Question)
//
//    текст питання(string)
//
//    відповідь(bool)
//Вікторина(Quiz)
//
//    список питань(List<Question>)
//
//    метод додавання питання(void AddQuestion(Question q))
//
//    метод запуску Тестування(void Run())
//
//Метод Run() запускає тестування, виводить кожне питання зі списку питань, аналізує відповіді на правильність
// та формує результат(кількість правильних)
//
namespace victoruna
{
    class Program
    {
        static Victo victo = new Victo();
        static Label textBox = new Label();
        static int counter = 0;

        static void Main(string[] args)
        {
            Form form = new Form();
            form.Size = new Size(400, 300);
            form.MaximumSize= new Size(400, 300);
            form.AutoSizeMode =AutoSizeMode.GrowAndShrink;
            form.Text = "Victorine";
            form.ForeColor=Color.Yellow;
            form.BackColor=Color.Black;

            Button yes = new Button();
            yes.Text = "yes";
            yes.TextAlign=ContentAlignment.BottomCenter;
            yes.Location = new Point(form.Size.Width/2- form.Size.Width / 4, 200);

            Button no = new Button();
            no.Text = "no";
            no.TextAlign = ContentAlignment.BottomCenter;
            no.Location = new Point(form.Size.Width/2, 200);
            
           
            textBox.Width = 300;
            textBox.Height = 100;
            textBox.Text="WELCOME\nAre you ready?";
            textBox.BorderStyle = BorderStyle.Fixed3D;
            textBox.Location = new Point(form.Size.Width / 8, 50);
            textBox.TextAlign=ContentAlignment.MiddleCenter;

            Qvestion qvestion1 = new Qvestion();
            Qvestion qvestion2 = new Qvestion();
            Qvestion qvestion3 = new Qvestion();
            qvestion1.qwest = "Is today mondey?";
            qvestion1.answer = false;
            victo.AddQuestion(qvestion1);
            qvestion2.qwest = "Is today tuesday?";
            qvestion2.answer = true;
            victo.AddQuestion(qvestion2);
            qvestion3.qwest = "Is today armagedon?";
            qvestion3.answer = false;
            victo.AddQuestion(qvestion3);


            yes.MouseClick += Yes_MouseClick;
            no.MouseClick += No_MouseClick;

            form.Controls.Add(yes);
            form.Controls.Add(no);
            form.Controls.Add(textBox);
            form.ShowDialog();
        }

        private static void No_MouseClick(object sender, MouseEventArgs e)
        {
            victo.Run(textBox, false,counter);
            counter++;
        }

        private static void Yes_MouseClick(object sender, MouseEventArgs e)
        {
            victo.Run(textBox, true,counter);
            counter++;
        }
    }
}
