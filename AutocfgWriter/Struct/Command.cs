using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct
{
    internal class Command
    {
        /// <summary>
        /// 注释
        /// </summary>
        public string[] anno { get; set; }
        /// <summary>
        /// command 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// alias 值
        /// </summary>
        public string Value { get; set; }
    }
}
