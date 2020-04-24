using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Написати програму «Калькулятор»
//__________________________________________________________________________________
//Форма калькулятора повинна містити: 
//10 кнопок з цифрами(0..9), 
//кнопку десяткової коми, 
//кнопку зміни знаку
//чотири кнопки арифметичних дій
//кнопку «дорівнює»
//кнопку видалення останнього символу(BackSpace)
//кнопку очищення дисплею
//кнопку повного очищення
//TextBox, котрий відіграє роль дисплею
//
//Калькулятор може перебувати у трьох режимах: 
//режим введення першого операнда
//режим введення другого операнда
//режим відображення результату.
//
//Режим введення першого операнда
//Калькулятор переходить в цей режим одразу після запуску, а також після натискання кнопки очищення дисплею.
//Дисплей містить символ 0, котрий буде замінений першою натисненою цифрою. 
//Якщо першою буде натиснена кнопки десяткової коми -- вона додається до вмісту одразу після нуля.
//Подальше натискання цифрових кнопок доповнює вміст дисплею -- цифра,
//що відповідає натисненій кнопці, дописується в кінець.
//При натисканні кнопки десяткової коми -- вона додається до вмісту лише,
//якщо її там досі не було (тобто, кома може бути лише одна).
//Натискання кнопки зміни знаку у будь-який момент змінює знак на протилежний(можна повторювати безліч разів)
//
//Режим введення другого операнда
//Калькулятор переходить в цей режим з режиму введення першого операнда 
//або режиму відображення результату після натискання кнопки арифметичної дії.
//Значення, що містилося на дисплеї десь запам'ятовується, натомість на дисплеї відображається 0.
//Подальша поведінка -- як у режимі введення першого операнда,
//з однією відмінністю -- натискання кнопки "дорівнює" обчислює результат дії, 
//а натискання кнопки арифметичної дії обчислює результат попередньої дії,
//запам'ятовує його як перший операнд нової дії і переводить калькулятор
// знову у режим введення другого операнда.
//
//
//Режим відображення результату
//Калькулятор переходить в цей режим після натискання кнопки "дорівнює",
//або обчислення тригонометричної функції (див.нижче).
//У цьому режимі при натисканні цифрових кнопок чи  кнопки десяткової коми дисплей очищається
//і калькулятор переходить в режим введення операнда та вводиться символ, що відповідає натисненій кнопці. 
//Натискання кнопки зміни знаку змінює знак на протилежний (можна повторювати безліч разів) 
//але не переводить калькулятор у режим введення операнда(тобто, не можна дописати цифри)
//
//
//Слід передбачити, щоби вміст «дисплея» змінювався лише "в кінці", тобто,
//нові цифри додавалися в кінець наявного тексту і при
//натисканні BackSpace видалалася остання цифра.Крім того, «дисплей» може містити лише цифри, кому і знак "мінус".
//Це -- умова на 10.
//
//
//
//калькулятор має також обробляти натискання на клавіші:
//клавіші  «з цифрами», «крапку» та «кому»,
//клавіші з символами арифметичних операцій,
//клавішу «Enter» для «дорівнює»
//клавішу «F9» для зміни знаку.

namespace Calculator
{
    public partial class Calculator : Form
    {
        bool point_ex = true;
        int temp = 0;
        string scrn_ = "";
        string math = "";
        Double memb =0;
        Double memb_two =0;
        Double res =0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void screen_TextChanged(object sender, EventArgs e)
        {
            res = Convert.ToDouble(scrn_);
            if (!point_ex)
            {
                screen.Text = scrn_;
                Text = res.ToString();
            }
            else
                screen.Text = res.ToString();
        }

        private void but_MouseClick(object sender, MouseEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "but0":    scrn_ = screen.Text + "0";
                    break;
                case "but1":    scrn_ = screen.Text + "1";
                    break;
                case "but2":    scrn_ = screen.Text + "2";
                    break;
                case "but3":    scrn_ = screen.Text + "3";
                    break;
                case "but4":    scrn_ = screen.Text + "4";
                    break;
                case "but5":    scrn_ = screen.Text + "5";
                    break;
                case "but6":    scrn_ = screen.Text + "6";
                    break;
                case "but7":    scrn_ = screen.Text + "7";
                    break;
                case "but8":    scrn_ = screen.Text + "8";
                    break;
                case "but9":    scrn_ = screen.Text + "9";
                    break;
                case "point":
                    if (point_ex)
                    {
                        temp = res.ToString().Length;
                        scrn_ = res.ToString().Insert(temp, ",");
                    }
                    point_ex = false;
                    break;
                case "but_pos_neg":
                    res *= -1;
                    scrn_ = res.ToString();
                    break;
                case "plus":    math = "+";
                    restart();
                    break;
                case "minus":   math = "-";
                    restart();
                    break;
                case "multi":   math = "*";
                    restart();
                    break;
                case "divate":  math = "/";
                    restart();
                    break;
                case "resal":
                    memb_two = res;
                    if (math == "+")
                        res = memb + memb_two;
                    else if (math == "-")
                        res = memb - memb_two;
                    else if(math == "*")
                        res = memb * memb_two;
                    else if(math == "/")
                    {
                        if (memb_two == 0)
                            MessageBox.Show("Divade on 0 !\nEnterdigit two");
                        else
                            res = memb / memb_two;
                    }
                    scrn_ = res.ToString();
                    break;
                default:
                    break;
            }
            
            screen_TextChanged(null, null);
        }

       void restart()
       {
            memb = res;
            res = 0;
            scrn_ = "0";
            point_ex = true;
       }

    }
}
