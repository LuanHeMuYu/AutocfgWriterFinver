using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Diagnostics;
using AutocfgWriter.Struct.ColorStruct;
using AutocfgWriter.Struct.KeyStruct;

namespace AutocfgWriter
{
    /// <summary>
    /// 解析输入的cfg文件
    /// </summary>
    internal class CfgParser
    {
        //cfg路径
        private string path;

        public CfgParser(string path)
        {
            this.path = path;
        }

        //具体解析的方法
        public void Parser()
        {
            List<string> anno = new List<string>();
            try
            {
                var lines = File.ReadLines(path);
                foreach (string line in lines)
                    if (line.StartsWith("//"))
                        anno.Add(line);
                    else if (line.StartsWith("bind"))
                    {
                        Cap.AddBind(line, anno.ToArray());
                        anno.Clear();
                    }
                    else if (line.StartsWith("alias"))
                    {
                        Cap.AddAlias(line, anno.ToArray());
                        anno.Clear();
                    }
                    else if (line.StartsWith("cl_glow"))
                    {
                        AzColor.ParseColor(line, anno);
                        anno.Clear();
                    }
                    else if (line.StartsWith("cl_crosshair"))
                    {
                        Cap.SetCrosshairColor(line);
                    }
                    else if (line != "")
                    {
                        //command
                        Cap.AddCommand(line, anno.ToArray());
                        anno.Clear();
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Cap.SetTailsAnnos(anno);

            Debug.WriteLine("Parse Finish!");
        }
    }
}
