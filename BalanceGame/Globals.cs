using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceGame
{
    public class Globals
    {
        public string[] language_list;

        //Default value
        public static readonly System.Drawing.Color backColor_default = System.Drawing.Color.FromName("HighLight");
        public static readonly string language_default = "English";
        public static readonly int weight_from_default = 1;
        public static readonly int weight_to_default = 10000;

        //Saved value
        public static System.Drawing.Color backColor;
        public static string language;
        public static decimal weight_from;
        public static decimal weight_to;
    }
}
