using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Utils
{
    internal static class StringSpliter
    {
        /// <summary>
        /// split with "Space" but you can limit size (size must > 0)
        /// </summary>
        /// <param name="s"> string </param>
        /// <returns> string[] </returns>
        public static string[] split(string s,int size) {
            if (size <= 0)
                return null;
            string[] strs = s.Split(" ");
            string[] res = new string[size];

            //把前面能放进去的放完
            for (int i = 0; i < size; i++)
                res[i] = strs[i];

            //这里把所有剩下的放到最后 但是每个之间记得加上" "
            while (size < strs.Length)
                res[res.Length - 1] += " " + strs[size++];

            return res;
        }
    }
}
