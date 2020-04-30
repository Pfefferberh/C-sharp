using System;
using System.Xml.Serialization;

namespace GameCommand
{
    [Serializable]
    [XmlInclude(typeof(Swordsman)), XmlInclude(typeof(Archer)), XmlInclude(typeof(Wizard))]
    public class Unit
    {
        public virtual string KindName { get; set; }
    }
}
