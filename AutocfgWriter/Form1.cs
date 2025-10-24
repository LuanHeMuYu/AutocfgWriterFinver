using AutocfgWriter.Struct.ColorStruct;

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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "cfg 文件 (.cfg)|*.cfg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    cp = new CfgParser(openFileDialog.FileName);
                    cp.Parser();
                }
            }
        }
    }
}
