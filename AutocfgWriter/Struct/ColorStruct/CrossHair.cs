using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct.ColorStruct
{
    //准星颜色 单独的 和其他区分开 (因为他跟的参数格式不一样)
    internal class CrossHair
    {
        int red { set; get; } = -1;
        int green { set; get; } = -1;
        int blue { set; get; } = -1;
        int alpha { set; get; } = -1;
        int dynamic { set; get; } = -1;
        int thickness { set; get; } = -1;
        int circle_alpha { set; get; } = -1;
        int circle_mode { set; get; } = -1;

        public CrossHair()
        {
            this.red = 0;
            this.green = 0;
            this.blue = 0;
        }

        public CrossHair(int r, int g, int b)
        {
            this.red = r;
            this.green = g;
            this.blue = b;
        }

        /// <summary>
        /// 解析准星颜色
        /// </summary>
        /// <param name="line"></param>
        public void parseLine(string line)
        {
            string[] strs = line.Split(" ");
            if (strs[0].EndsWith("red"))
                setRed(int.Parse(strs[1]));
            else if (strs[0].EndsWith("green"))
                setGreen(int.Parse(strs[1]));
            else if (strs[0].EndsWith("blue"))
                setBlue(int.Parse(strs[1]));
        }

        public void setRed(int r)
        {
            this.red = r;
        }

        public void setGreen(int g)
        {
            this.green = g;
        }

        public void setBlue(int b)
        {
            this.blue = b;
        }

        /// <summary>
        /// 通过反射获取所有字段
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            

            return sb.ToString();
        }

    }
}
