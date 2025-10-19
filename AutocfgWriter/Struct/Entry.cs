using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutocfgWriter.Struct
{
    /// <summary>
    /// This is base of Alias & Bind
    /// </summary>
    internal class Entry
    {
        /// <summary>
        /// 每个条目的唯一标识符
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 每个条目的值 (可能后文不会用string 可能会用Entry)
        /// </summary>
        public string Value { get; set; }

        string info() {
            return "This is default Entry";
        }
    }
}
