using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum Pojistovny
    {
        VZP,
        OZP,
        ZPMV
    }

    public static class Pojistovna
    {
        public static readonly int Count = Enum.GetValues(typeof(Pojistovny)).Length;

        public static IEnumerable Items
        {
            get
            {
                return Enum.GetValues(typeof(Pojistovny));
            }
        }

        public static string GetName(Pojistovny pojistovna)
        {
            switch (pojistovna)
            {
                case Pojistovny.VZP:
                    return "Všeobecná Z.P.";
                case Pojistovny.OZP:
                    return "Oborová Z.P.";                
                case Pojistovny.ZPMV:
                    return "Z.P. ministerstva vnitra ČR";
                default:
                    return "";
            }
        }
    }

}
