using AutocfgWriter.Struct.ColorStruct;
using AutocfgWriter.Struct.KeyStruct;
using AutocfgWriter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter
{
    internal static class Cap
    {
        //所有alias
        private static Dictionary<string, Tuple<string, string[]>> aliases = new Dictionary<string, Tuple<string, string[]>>();
        //所有binds 
        private static Dictionary<string, Tuple<string, string[]>> binds = new Dictionary<string, Tuple<string, string[]>>();
        //所有的纯指令类
        private static HashSet<Tuple<string, string[]>> commands = new HashSet<Tuple<string, string[]>>();
        //可能存在的末尾注释
        private static List<string> TailsAnno = new List<string>();
        //颜色类
        public static HashSet<AzColor> colors = new HashSet<AzColor>();
        //准星颜色
        public static HashSet<CrossHairColor> crosshairColor = new HashSet<CrossHairColor>();
        //颜色分类和注释
        public static Dictionary<string, AzColor> colorEntry = new Dictionary<string, AzColor>();

        public static void addAlias(string line, string[] annos)
        {
            string[] strs = StringSpliter.split(line, 3);
            aliases.Add(strs[1], new Tuple<string, string[]>(strs[2], annos));
        }

        public static void addBind(string line, string[] annos)
        {
            string[] strs = StringSpliter.split(line, 3);
            binds.Add(strs[1], new Tuple<string, string[]>(strs[2], annos));
        }

        public static void addCommand(string line, string[] annos)
        {
            commands.Add(new Tuple<string, string[]>(line, annos));
        }

        public static void addAnno(string s)
        {
            TailsAnno.Add(s);
        }

        public static void addColor(AzColor ac)
        {
            colors.Add(ac);
        }
        public static void removeColor(AzColor ac)
        {
            colors.Remove(ac);
        }

        public static void addCrosshairColor(CrossHairColor cc)
        {
            crosshairColor.Add(cc);
        }

        public static void removeCrosshairColor(CrossHairColor cc)
        {
            crosshairColor.Remove(cc);
        }

        public static void setTailsAnnos(List<string> annos)
        {
            TailsAnno = annos;
        }

    }
}
