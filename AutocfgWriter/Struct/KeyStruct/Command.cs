using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct.KeyStruct
{
    // 2025年11月4日 Reconstruct command
    // string * 2 ==> HashSet<Tuple<string, string[]>>
    // Tuple 内的元素解释: 
    //      指令 + 注释
    [Obsolete("这个类已经被Hashset替换，请不要再使用了",true)]
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
