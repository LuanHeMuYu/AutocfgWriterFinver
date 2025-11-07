using AutocfgWriter.Struct.ColorStruct;
using AutocfgWriter.Utils;
using System.Windows.Forms;

namespace AutocfgWriter
{
    public partial class Form1 : Form
    {
        CfgParser cp = null;

        public Form1()
        {
            InitializeComponent();

            //初始化colorEntry
            try
            {
                var lines = File.ReadLines("D:\\csProject\\AutocfgWriterFinVer\\AutocfgWriterFinver\\AutocfgWriter\\ColorsTemplate.txt");
                foreach (string line in lines)
                {
                    string[] split = line.Split();
                    Cap.colorEntry.TryAdd(split[0], new AzColor(split[1]) { command = split[0], explainer = split[2] });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = OtherUtils.PopFileChoose();
            if (!path.Equals(DialogResult.Cancel | DialogResult.No))
            {
                cp = new CfgParser(path);
                cp.Parser();
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = OtherUtils.PopFolderChoose();
            if (!path.Equals(DialogResult.Cancel | DialogResult.No))
            {
                Cap.export(path);
            }
        }
        /// <summary>
        /// 更改下面的提示词
        /// </summary>
        /// <param name="text">字符串</param>
        /// <param name="isParse">是否解析这串字符</param>
        public void ChangeStripText(string text,bool isParse) {
            if (isParse)
            {
                //解析就是先去Cap里面寻找有没有这个键位的存在 如果没有 那么就显示空
                Tuple<string, string[]> val = Cap.getValInBinds(text);
                if (val.Item1 == "none")
                    this.toolStripLabel.Text = "还未绑定键位";
                else
                    this.toolStripLabel.Text = val.Item1;
            }
            else
                this.toolStripLabel.Text = text;
        }
    }
}
