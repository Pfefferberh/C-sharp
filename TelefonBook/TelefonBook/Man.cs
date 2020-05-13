using System.Drawing;

namespace TelefonBook
{
    public class Man
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Show { get { return Name + "     " + Number; } }
        public Image Fotka { get; set; }
    }
}
