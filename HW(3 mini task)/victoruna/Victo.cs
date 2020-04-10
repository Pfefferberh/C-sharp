using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace victoruna
{
    class Victo
    {
        List< Qvestion> qvestion = new List<Qvestion>();
        int count_tru = 0, count_fals = 0;
        public void AddQuestion(Qvestion q)
        {
            qvestion.Add(q);
        }

        public void Run(Label label,bool answ,int count)
        {
            if (this.qvestion.Count > count) {
                label.Text = this.qvestion.ElementAt(count).qwest;
                if (this.qvestion[count].answer == answ)
                    count_tru++;
                else
                    count_fals++;
            }
            else {
                label.Text = $"true: {this.count_tru}" + $"    false: {this.count_fals}";
            }
        }
    }
}
