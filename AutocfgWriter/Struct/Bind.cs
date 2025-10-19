using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct
{
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
            string[] strs = str.Split(" ");
            this.Name = strs[1];
            this.Value = strs[2];
        }

        public Bind(string str, string[] anno)
        {
            string[] strs = str.Split(" ");
            this.Name = strs[1];
            this.Value = strs[2];
            this.anno = anno;
        }
    }
}
