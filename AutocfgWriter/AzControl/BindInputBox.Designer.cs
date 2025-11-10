namespace AutocfgWriter.AzControl
{
    partial class BindInputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_Effects = new Label();
            CommPanel = new Panel();
            AddCustomComm = new Button();
            CustomCommTextBox = new TextBox();
            Lebel_CustomComm = new Label();
            AlreadyEffets = new Label();
            Label_AlreadyEffects = new Label();
            SuspendLayout();
            // 
            // Label_Effects
            // 
            Label_Effects.AutoSize = true;
            Label_Effects.Location = new Point(12, 9);
            Label_Effects.Name = "Label_Effects";
            Label_Effects.Size = new Size(114, 20);
            Label_Effects.TabIndex = 0;
            Label_Effects.Text = "想要实现的效果";
            // 
            // CommPanel
            // 
            CommPanel.Location = new Point(12, 32);
            CommPanel.Name = "CommPanel";
            CommPanel.Size = new Size(250, 344);
            CommPanel.TabIndex = 1;
            // 
            // AddCustomComm
            // 
            AddCustomComm.Location = new Point(262, 382);
            AddCustomComm.Name = "AddCustomComm";
            AddCustomComm.Size = new Size(132, 56);
            AddCustomComm.TabIndex = 2;
            AddCustomComm.Text = "确认";
            AddCustomComm.UseVisualStyleBackColor = true;
            // 
            // CustomCommTextBox
            // 
            CustomCommTextBox.Location = new Point(12, 411);
            CustomCommTextBox.Name = "CustomCommTextBox";
            CustomCommTextBox.Size = new Size(244, 27);
            CustomCommTextBox.TabIndex = 3;
            // 
            // Lebel_CustomComm
            // 
            Lebel_CustomComm.AutoSize = true;
            Lebel_CustomComm.Location = new Point(12, 379);
            Lebel_CustomComm.Name = "Lebel_CustomComm";
            Lebel_CustomComm.Size = new Size(144, 20);
            Lebel_CustomComm.TabIndex = 4;
            Lebel_CustomComm.Text = "或者是自己输入指令";
            // 
            // AlreadyEffets
            // 
            AlreadyEffets.BackColor = SystemColors.ControlDark;
            AlreadyEffets.Location = new Point(400, 32);
            AlreadyEffets.Name = "AlreadyEffets";
            AlreadyEffets.Size = new Size(388, 409);
            AlreadyEffets.TabIndex = 5;
            // 
            // Label_AlreadyEffects
            // 
            Label_AlreadyEffects.AutoSize = true;
            Label_AlreadyEffects.Location = new Point(401, 5);
            Label_AlreadyEffects.Name = "Label_AlreadyEffects";
            Label_AlreadyEffects.Size = new Size(189, 20);
            Label_AlreadyEffects.TabIndex = 6;
            Label_AlreadyEffects.Text = "已经实现的效果在这里显示";
            // 
            // BindInputBox
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_AlreadyEffects);
            Controls.Add(AlreadyEffets);
            Controls.Add(Lebel_CustomComm);
            Controls.Add(CustomCommTextBox);
            Controls.Add(AddCustomComm);
            Controls.Add(CommPanel);
            Controls.Add(Label_Effects);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BindInputBox";
            Text = "关闭窗口以保存";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Effects;
        private Panel CommPanel;
        private Button AddCustomComm;
        private TextBox CustomCommTextBox;
        private Label Lebel_CustomComm;
        private Label AlreadyEffets;
        private Label Label_AlreadyEffects;
    }
}