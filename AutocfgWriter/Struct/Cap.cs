using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Struct
{
    internal static class Cap
    {
        //所有alias
        public static List<Alias> aliases = new List<Alias>();
        //所有binds
        public static List<Bind> binds = new List<Bind>();
        //所有的纯指令类
        public static List<Command> commands = new List<Command>();
        //可能存在的末尾注释
        public static List<string> TailsAnno = new List<string>();

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

    }
}
