using AutocfgWriter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct.KeyStruct
{
    // 2025年11月4日 Reconstruct Bind
    // string * 3 ==> HashMap<string,Tuple<string,string>>
    // Tuple 内的元素解释: 
    //      指令 + 注释
    [Obsolete("这个类已经被Dict替代了，不要再使用了", true)]
    internal class Bind
    {
        /// <summary>
        /// 注释
        /// </summary>
        public string[] anno { get; set; }
        /// <summary>
        /// bind 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// bind 值
        /// </summary>
        public string Value { get; set; }
        //解析输入的str
        public Bind(string str) {
            string[] strs = StringSpliter.split(str,3);
            Name = strs[1];
            Value = strs[2];
        }

        public Bind(string str, string[] anno)
        {
            string[] strs = StringSpliter.split(str,3);
            Name = strs[1];
            Value = strs[2];
            this.anno = anno;
        }
    }
}
