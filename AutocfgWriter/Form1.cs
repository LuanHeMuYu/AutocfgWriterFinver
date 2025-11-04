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

            //≥ı ºªØcolorEntry
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
    }
}
