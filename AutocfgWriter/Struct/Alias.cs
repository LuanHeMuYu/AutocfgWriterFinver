using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct
{
    internal class Alias
    {
        /// <summary>
        /// 注释
        /// </summary>
        public string[] anno { get; set; }
        /// <summary>
        /// alias 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// alias 值
        /// </summary>
        public string Value { get; set; }

        public Alias(string str)
        {
            string[] strs = str.Split(" ");
            this.Name = strs[1];
            this.Value = strs[2];
        }

        public Alias(string str, string[] anno)
        {
            string[] strs = str.Split(" ");
            this.Name = strs[1];
            this.Value = strs[2];
            this.anno = anno;
        }


        public override bool Equals(object? obj)
        {
            return obj.GetHashCode == this.GetHashCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(anno, Name, Value);
        }
    }
}
