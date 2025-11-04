using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutocfgWriter.Struct.ColorStruct;
using AutocfgWriter.Struct.KeyStruct;

namespace AutocfgWriter
{
    internal static class Cap
    {
        //所有alias
        public static List<Alias> aliases = new List<Alias>();
        //所有binds 
        public static Dictionary<string, Tuple<string, string[]>> Bind = new Dictionary<string, Tuple<string, string[]>>();
        //所有的纯指令类
        public static List<Command> commands = new List<Command>();
        //可能存在的末尾注释
        public static List<string> TailsAnno = new List<string>();
        //颜色类
        public static HashSet<AzColor> colors = new HashSet<AzColor>();
        //准星颜色
        public static HashSet<CrossHairColor> crosshairColor = new HashSet<CrossHairColor>();

        //颜色分类和注释
        public static Dictionary<string, AzColor> colorEntry = new Dictionary<string, AzColor>();

        public static void addAlias(Alias e) { 
            aliases.Add(e);
        }

        public static void removeAlias(Alias alias) {
            aliases.Remove(alias);
        }

        public static void addBind(Bind e)
        {
            binds.Add(e);
        }

        public static void removeBind(Bind bind) { 
            binds.Remove(bind);
        }
        public static void addCommand(Command e)
        {
            commands.Add(e);
        }

        public static void removeCommand(Command com) { 
            commands.Remove(com);
        }
        public static void addAnno(string s) {
            TailsAnno.Add(s);
        }

        public static void addColor(AzColor ac) {
            colors.Add(ac);
        }
        public static void removeColor(AzColor ac) {
            colors.Remove(ac);
        }

        public static void addCrosshairColor(CrossHairColor cc) { 
            crosshairColor.Add(cc);
        }

        public static void removeCrosshairColor(CrossHairColor cc) { 
            crosshairColor.Remove(cc);
        }

    }
}
