using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        bool point_ex = true;//filter comms
        bool bad_key = true;//the filter of doing the laundry by the keyboard

        int temp = 0; //coma index tracking

        string scrn_ = "";//to read values ​​from the screen
        string math = "";//for math oprration

        Double memb = 0;
        Double memb_two = 0;
        Double res = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void screen_TextChanged(object sender, EventArgs e)
        {
            if (bad_key)
            {
                res = Convert.ToDouble(scrn_);
                if (!point_ex)
                    screen.Text = scrn_;
                else
                    screen.Text = res.ToString();

            }
            bad_key = true;
        }

        private void but_MouseClick(object sender, MouseEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "D0":
                    scrn_ = screen.Text + "0";
                    break;
                case "D1":
                    scrn_ = screen.Text + "1";
                    break;
                case "D2":
                    scrn_ = screen.Text + "2";
                    break;
                case "D3":
                    scrn_ = screen.Text + "3";
                    break;
                case "D4":
                    scrn_ = screen.Text + "4";
                    break;
                case "D5":
                    scrn_ = screen.Text + "5";
                    break;
                case "D6":
                    scrn_ = screen.Text + "6";
                    break;
                case "D7":
                    scrn_ = screen.Text + "7";
                    break;
                case "D8":
                    scrn_ = screen.Text + "8";
                    break;
                case "D9":
                    scrn_ = screen.Text + "9";
                    break;
                default:
                    but_operat_MouseClick(sender, e);
                    return;
            }
            screen_TextChanged(null, null);
        }

        private void but_operat_MouseClick(object sender, MouseEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "Add":
                case "Oemplus":
                    math = "+";
                    restart();
                    break;
                case "Subtract":
                case "OemMinus":
                    math = "-";
                    restart();
                    break;
                case "Multiply":
                    math = "*";
                    restart();
                    break;
                case "Divide":
                    math = "/";
                    restart();
                    break;
                case "resal":
                    memb_two = res;
                    if (math == "+")
                        res = memb + memb_two;
                    else if (math == "-")
                        res = memb - memb_two;
                    else if (math == "*")
                        res = memb * memb_two;
                    else if (math == "/")
                    {
                        if (memb_two == 0)
                            MessageBox.Show("Divade on 0 !\nEnter digit two!!");
                        else
                            res = memb / memb_two;
                    }
                    scrn_ = res.ToString();
                    memb = 0;
                    break;
                default:
                    but_option_MouseClick(sender, e);
                    return;
            }
            screen_TextChanged(null, null);

        }
        private void but_option_MouseClick(object sender, MouseEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "Oemcomma":
                    if (point_ex)
                    {
                        temp = res.ToString().Length;
                        scrn_ = res.ToString().Insert(temp, ",");
                    }
                    point_ex = false;
                    break;
                case "F9":
                    res *= -1;
                    scrn_ = res.ToString();
                    break;

                case "Back":
                    if (scrn_.LastOrDefault() == ',')
                    {
                        scrn_ = scrn_.Remove(scrn_.Length - 1, 1);
                        point_ex = true;
                    }
                    else if (scrn_.Length > 0)
                        scrn_ = scrn_.Remove(scrn_.Length - 1, 1);
                    if (scrn_.Length == 0 || scrn_ == "-")
                    {
                        scrn_ = "0";
                        screen.Text = "";
                        point_ex = true;
                    }
                    break;
                case "Oemtilde":
                    scrn_ = scrn_.Remove(0, scrn_.Length - 1);
                    scrn_ = "0";
                    point_ex = true;
                    break;
                case "Delete":
                    point_ex = true;
                    temp = 0;
                    scrn_ = "0";
                    math = "";
                    memb = 0;
                    memb_two = 0;
                    res = 0;
                    break;
                default:
                    bad_key = false;
                    return;
            }
            screen_TextChanged(null, null);
        }
        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            Button button = new Button();
            if (e.KeyValue == 13)
                button.Name = "resal";
            else
                button.Name = e.KeyCode.ToString();

            but_MouseClick(button, null);
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
