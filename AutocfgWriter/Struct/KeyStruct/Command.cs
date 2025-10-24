using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct.KeyStruct
{
    internal class Command
    {
        /// <summary>
        /// 注释
        /// </summary>
        public string[] anno { get; set; }
        /// <summary>
        /// command 值
        /// </summary>
        public string Value { get; set; }

        public Command(string line) {
            Value = line;
        }
        public Command(string line,string[] anno)
        {
            Value = line;
            this.anno = anno;
        }

    }
}
