namespace AutocfgWriter
{
    public partial class Form1 : Form
    {
        CfgParser cp = new CfgParser("C:/Users/Administrator/Downloads/autoexec.cfg");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cp.Parser();
        }
    }
}
