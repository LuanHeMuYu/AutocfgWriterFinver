namespace AutocfgWriter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ImportToolStripMenuItem = new ToolStripMenuItem();
            ExportToolStripMenuItem = new ToolStripMenuItem();
            PreviewcfgToolStripMenuItem = new ToolStripMenuItem();
            TabControl = new TabControl();
            KeyBind = new TabPage();
            ColorEdge = new TabPage();
            导入语言包ToolStripMenuItem = new ToolStripMenuItem();
            ColorEdgeDetails = new TabControl();
            HumanVisionColor = new TabPage();
            SpecialInfectedVision = new TabPage();
            CrossHairColor = new TabPage();
            SpectatorVision = new TabPage();
            menuStrip1.SuspendLayout();
            TabControl.SuspendLayout();
            ColorEdge.SuspendLayout();
            ColorEdgeDetails.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ImportToolStripMenuItem, ExportToolStripMenuItem, PreviewcfgToolStripMenuItem, 导入语言包ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1206, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ImportToolStripMenuItem
            // 
            ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            ImportToolStripMenuItem.Size = new Size(53, 24);
            ImportToolStripMenuItem.Text = "导入";
            ImportToolStripMenuItem.Click += ImportToolStripMenuItem_Click;
            // 
            // ExportToolStripMenuItem
            // 
            ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            ExportToolStripMenuItem.Size = new Size(53, 24);
            ExportToolStripMenuItem.Text = "导出";
            // 
            // PreviewcfgToolStripMenuItem
            // 
            PreviewcfgToolStripMenuItem.Name = "PreviewcfgToolStripMenuItem";
            PreviewcfgToolStripMenuItem.Size = new Size(76, 24);
            PreviewcfgToolStripMenuItem.Text = "预览cfg";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(KeyBind);
            TabControl.Controls.Add(ColorEdge);
            TabControl.Location = new Point(12, 31);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1194, 730);
            TabControl.TabIndex = 1;
            // 
            // KeyBind
            // 
            KeyBind.Location = new Point(4, 29);
            KeyBind.Name = "KeyBind";
            KeyBind.Padding = new Padding(3);
            KeyBind.Size = new Size(1186, 697);
            KeyBind.TabIndex = 0;
            KeyBind.Text = "按键绑定";
            KeyBind.UseVisualStyleBackColor = true;
            // 
            // ColorEdge
            // 
            ColorEdge.Controls.Add(ColorEdgeDetails);
            ColorEdge.Location = new Point(4, 29);
            ColorEdge.Name = "ColorEdge";
            ColorEdge.Padding = new Padding(3);
            ColorEdge.Size = new Size(1186, 697);
            ColorEdge.TabIndex = 1;
            ColorEdge.Text = "颜色绑定";
            ColorEdge.UseVisualStyleBackColor = true;
            // 
            // 导入语言包ToolStripMenuItem
            // 
            导入语言包ToolStripMenuItem.Name = "导入语言包ToolStripMenuItem";
            导入语言包ToolStripMenuItem.Size = new Size(98, 24);
            导入语言包ToolStripMenuItem.Text = "导入语言包";
            // 
            // ColorEdgeDetails
            // 
            ColorEdgeDetails.Controls.Add(HumanVisionColor);
            ColorEdgeDetails.Controls.Add(SpecialInfectedVision);
            ColorEdgeDetails.Controls.Add(CrossHairColor);
            ColorEdgeDetails.Controls.Add(SpectatorVision);
            ColorEdgeDetails.Location = new Point(6, 6);
            ColorEdgeDetails.Name = "ColorEdgeDetails";
            ColorEdgeDetails.SelectedIndex = 0;
            ColorEdgeDetails.Size = new Size(1174, 685);
            ColorEdgeDetails.TabIndex = 0;
            // 
            // HumanVisionColor
            // 
            HumanVisionColor.Location = new Point(4, 29);
            HumanVisionColor.Name = "HumanVisionColor";
            HumanVisionColor.Padding = new Padding(3);
            HumanVisionColor.Size = new Size(1166, 652);
            HumanVisionColor.TabIndex = 0;
            HumanVisionColor.Text = "人类视角颜色边框";
            HumanVisionColor.UseVisualStyleBackColor = true;
            // 
            // SpecialInfectedVision
            // 
            SpecialInfectedVision.Location = new Point(4, 29);
            SpecialInfectedVision.Name = "SpecialInfectedVision";
            SpecialInfectedVision.Padding = new Padding(3);
            SpecialInfectedVision.Size = new Size(1166, 652);
            SpecialInfectedVision.TabIndex = 1;
            SpecialInfectedVision.Text = "特感视角颜色边框";
            SpecialInfectedVision.UseVisualStyleBackColor = true;
            // 
            // CrossHairColor
            // 
            CrossHairColor.Location = new Point(4, 29);
            CrossHairColor.Name = "CrossHairColor";
            CrossHairColor.Padding = new Padding(3);
            CrossHairColor.Size = new Size(1166, 652);
            CrossHairColor.TabIndex = 2;
            CrossHairColor.Text = "准星颜色";
            CrossHairColor.UseVisualStyleBackColor = true;
            // 
            // SpectatorVision
            // 
            SpectatorVision.Location = new Point(4, 29);
            SpectatorVision.Name = "SpectatorVision";
            SpectatorVision.Padding = new Padding(3);
            SpectatorVision.Size = new Size(1166, 652);
            SpectatorVision.TabIndex = 3;
            SpectatorVision.Text = "旁观者颜色边框";
            SpectatorVision.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 773);
            Controls.Add(TabControl);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AutoCfgWriter - Powered by Azazel";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            TabControl.ResumeLayout(false);
            ColorEdge.ResumeLayout(false);
            ColorEdgeDetails.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ImportToolStripMenuItem;
        private ToolStripMenuItem ExportToolStripMenuItem;
        private ToolStripMenuItem PreviewcfgToolStripMenuItem;
        private TabControl TabControl;
        private TabPage KeyBind;
        private TabPage ColorEdge;
        private ToolStripMenuItem 导入语言包ToolStripMenuItem;
        private TabControl ColorEdgeDetails;
        private TabPage HumanVisionColor;
        private TabPage SpecialInfectedVision;
        private TabPage CrossHairColor;
        private TabPage SpectatorVision;
    }
}
