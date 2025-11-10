using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct.ColorStruct
{
    internal class AzColor
    {
        public enum Type { 
            Human,Infected,Spectator
        }

        //Red
        public double r { set; get; }
        //Green
        public double g { set; get; }
        //Blue
        public double b { set; get; }

        public List<string> annos = new List<string>();

        public string command { set; get; }
        public string? explainer { set; get; }

        public List<Type> types = new List<Type>();

        public AzColor() { 
            r = 0; g = 0; b = 0;
        }

        public AzColor(string types) {
            this.types.Add(ParseType(types));
        }

        public AzColor(double r, double g, double b, List<string> annos, string command, string? explainer, List<Type> types)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.annos = annos;
            this.command = command;
            this.explainer = explainer;
            this.types = types;
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <returns></returns>
        public string[] Export()
        {
            return new string[] {
                command + "_r " + r,
                command + "_g " + g,
                command + "_b " + b
            };
        }

        public Type ParseType(string str) {
            switch (str) {
                case "Human":
                    return Type.Human;
                case "Infected":
                    return Type.Infected;
                default:
                    return Type.Spectator;
            }
        }

        /// <summary>
        /// 解析颜色 (using string)
        /// </summary>
        /// <param name="str">文本</param>
        /// <param name="annos">注释</param>
        public static void ParseColor(string str, List<string> annos)
        {
            string[] split = str.Split(" ");
            string command = split[0].Substring(0, split[0].Length - 2);
            string val = split[0].Substring(split[0].Length - 2,2);

            foreach (var color in Cap.colors)
            {
                if (color.command == command) {
                    if (val == "_r")
                        color.r = Convert.ToDouble(split[1]);
                    else if(val == "_g")
                        color.g = Convert.ToDouble(split[1]);
                    else if(val == "_b")
                        color.b = Convert.ToDouble(split[1]);
                    //如果有多的注释 可以加到原来的上面
                    if(annos.Count != 0)
                        color.annos.AddRange(annos);
                    return;     
                }
            }

            //Add new color
            AzColor addColor = new();
            if (val == "_r")
                addColor.r = Convert.ToDouble(split[1]);
            else if (val == "_g")
                addColor.g = Convert.ToDouble(split[1]);
            else if (val == "_b")
                addColor.b = Convert.ToDouble(split[1]);
            addColor.annos.AddRange(annos);
            addColor.command = command;

            AzColor types = null;
            Cap.colorEntry.TryGetValue(command, out types);

            if (types != null && types.types.Count != 0)
                addColor.types = types.types;
            else
                addColor.types.Add(Type.Human);


            Cap.colors.Add(addColor);
        }
    }
}
