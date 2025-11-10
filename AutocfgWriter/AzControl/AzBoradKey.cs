using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutocfgWriter.UserControl
{
    public partial class AzBoradKey : Control
    {
        private float width = -1, height = -1;
        private string drawString = string.Empty;
        public AzBoradKey()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            //在最开始的时候 获取要绘制的文本长度和高度 然后确定绘制的位置
            if (height == -1 || width == -1)
            {
                drawString = this.Text;
                string text = drawString;
                SizeF size = pe.Graphics.MeasureString(text, Font);
                height = this.Height / 2 - size.Height / 2;
                width = this.Width / 2 - size.Width / 2;

                //if (drawString == "")
                //    drawString = this.Name;
            }


            pe.Graphics.DrawString($"{drawString}", Font, Brushes.Black, new PointF(width, height));
            pe.Graphics.DrawRectangle(Pens.Black,new RectangleF(0,0,this.Width - 1,this.Height - 1));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseHover(e);
            if (this.TopLevelControl is Form1 form) {
                form.ChangeStripText(this.Name.Replace("Key_",""),true);
            }
        }

        /// <summary>
        /// 这个方法我希望能弹出来一个窗口 然后显示具体的效果
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        /// <summary>
        /// 这个方法我希望能弹出来一个窗口 然后你可以进行键位的绑定
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
        }
    }
}
