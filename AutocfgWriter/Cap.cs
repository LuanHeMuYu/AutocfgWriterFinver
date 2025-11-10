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
        static string[] dict = new string[] {
            "f1", "f2", "f3", "f4", "f5", "f6", "f7", "f8", "f9", "f10", "f11", "f12",
            "escape","tab","capslock","shift","rshift","ctrl","rctrl","alt","ralt","space","backspace","enter",
            "semicolon","lwin","rwin","apps","numlock","scrolllock","uparrow","downarrow","leftarrow","rightarrow",
            "ins","del","pgdn","pgup","home","end","pause","kp_end","kp_downarrow","kp_pgdn","kp_leftarrow","kp_5",
            "kp_rightarrow","kp_home","kp_uparrow","kp_pgup","kp_enter","kp_ins","kp_del","kp_slash","kp_multiply",
            "kp_minus","kp_plus","mwheeldown","mwheelup","mouse1","mouse2","mouse3","mouse4","mouse5"
        };
        //有些大小写可能重合的键位 我需要把大小写统一了
        private static HashSet<string> distinct = new HashSet<string>();
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
        //准星颜色 r g b annos
        public static CrossHair crosshairColor = new CrossHair();
        //颜色分类和注释
        public static Dictionary<string, AzColor> colorEntry = new Dictionary<string, AzColor>();

        static Cap()
        {
            foreach (char c in "abcdefghijklmnopqrstuvwxyz")
                distinct.Add(Convert.ToString(c));
            foreach (string s in dict)
                distinct.Add(s);
        }
        public static void AddAlias(string line, string[] annos)
        {
            string[] strs = StringSpliter.Split(line, 3);
            aliases.Add(strs[1], new Tuple<string, string[]>(strs[2], annos));
        }

        public static void AddBind(string line, string[] annos)
        {
            string[] strs = StringSpliter.Split(line, 3);
            //添加的时候 我们需要判断所有字符小写化后 会不会在distinct里面出现
            //如果会 那么就只放小写后的string了
            if (!distinct.Contains(strs[1].ToLower().Trim()))
                binds.Add(strs[1], new Tuple<string, string[]>(strs[2], annos));
            else
                binds.Add(strs[1].ToLower().Trim(), new Tuple<string, string[]>(strs[2], annos));
        }
        /// <summary>
        /// 添加一个Bind到binds
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="val">Val</param>
        /// <param name="annos">注释</param>
        public static void AddBind(string key, string val, string[] annos = null)
        {
            if(annos == null)
                binds.Add(key, new Tuple<string, string[]>(val, Array.Empty<string>()));
            else
                binds.Add(key, new Tuple<string, string[]>(val, annos));
        }


        public static void AddCommand(string line, string[] annos)
        {
            commands.Add(new Tuple<string, string[]>(line, annos));
        }

        public static void addAnno(string s)
        {
            TailsAnno.Add(s);
        }

        public static void AddColor(AzColor ac)
        {
            colors.Add(ac);
        }
        public static void RemoveColor(AzColor ac)
        {
            colors.Remove(ac);
        }

        public static void SetCrosshairColor(string line)
        {
            crosshairColor.ParseLine(line);
        }

        public static void SetTailsAnnos(List<string> annos)
        {
            TailsAnno = annos;
        }

        //查看binds是否存在{key} 并尝试返回他 如果没有 会返回none
        public static Tuple<string, string[]> GetValInBinds(string key)
        {
            return binds.GetValueOrDefault(key, new Tuple<string, string[]>("none", []));
        }

        /// <summary>
        /// 把所有的Cap导出到一个位置去
        /// </summary>
        public static void Export(string output)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(output, "yourcfg.cfg")))
            {
                //Binds
                foreach (var item in binds)
                {
                    string key = item.Key;
                    string val = item.Value.Item1;
                    string[] annos = item.Value.Item2;

                    //annos first
                    foreach (string anno in annos)
                        sw.WriteLine(anno);
                    //bind + key + val
                    sw.WriteLine($"bind {key} {val}");
                }

                //Alias
                foreach (var item in aliases)
                {
                    string key = item.Key;
                    string val = item.Value.Item1;
                    string[] annos = item.Value.Item2;

                    //annos first
                    foreach (string anno in annos)
                        sw.WriteLine(anno);
                    sw.WriteLine($"alias {key} {val}");
                }

                //command
                foreach (var item in commands)
                {
                    string command = item.Item1;
                    string[] annos = item.Item2;

                    //annos first
                    foreach (string anno in annos)
                        sw.WriteLine(anno);
                    sw.WriteLine($"{command}");
                }

                //TODO: 颜色导出 
                // 颜色导出
                foreach (AzColor color in colors)
                {
                    foreach (string anno in color.annos)
                        sw.WriteLine(anno);
                    sw.WriteLine($"{color.command}_r {color.r}");
                    sw.WriteLine($"{color.command}_g {color.g}");
                    sw.WriteLine($"{color.command}_b {color.b}");
                }

                //准星颜色导出
                sw.WriteLine(crosshairColor.ToString());
            }
        }

    }
}
