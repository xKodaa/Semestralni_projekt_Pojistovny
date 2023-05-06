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
                    return "Všeobecná zdravotní pojišťovna";
                case Pojistovny.OZP:
                    return "Oborová zdravotní pojišťovna";                
                case Pojistovny.ZPMV:
                    return "Zdravotní pojišťovna ministerstva vnitra ČR";
                default:
                    return "";
            }
        }
    }

}
