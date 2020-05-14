using System.Collections.Generic;

namespace EXAM
{
    public class Qwestion
    {
        public List<string> qwest;
        public List<int> tryest;
        public string Text { get; set; }
        public Qwestion()
        {
            qwest = new List<string>();
            tryest = new List<int>();
        }
       // public int TrueAns { get { };  }
    }
}
