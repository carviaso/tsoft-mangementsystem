using System;
using System.Collections.Generic;
using System.Text;

namespace TS.Sys.Util
{
    public class NumberUtil
    {
        public static Decimal GetAmt(String o)
        {
            o = o.Substring(1);
            Decimal amt = Decimal.Parse(o);
            return amt;
        }

        public static String FormatAMT(Object amtIn)
        {
            Decimal amt = Decimal.Parse(amtIn.ToString().Trim());
            amt = Math.Round(amt, 2);
            String pre1 = "";
            String pre2 = "";
            String precision = "￥";
            for (int i = 0; i < 2; i++)
            {
                pre1 += "#";
                pre2 += "0";
            }
            String _amtFormatter = "0." + pre2 + ";";
            precision += "#," + pre1 + _amtFormatter;
            return amt.ToString(precision + "-" + precision + "");

        }

         
    }
}
