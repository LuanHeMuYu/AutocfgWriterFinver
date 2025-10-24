namespace AutocfgWriter
{
    public partial class Form1 : Form
    {
        CfgParser cp = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "cfg нд╪Ч (.cfg)|*.cfg";

                if (openFileDialog.ShowDialog() == DialogResult.OK) { 
                    cp = new CfgParser(openFileDialog.FileName);
                    cp.Parser();
                }
            }
        }
    }
}
