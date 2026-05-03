namespace ShortcutLinkChecker
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
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(31, 340);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 0;
            button1.Text = "スキャン開始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(31, 67);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(498, 259);
            listBox1.TabIndex = 2;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(31, 19);
            button2.Name = "button2";
            button2.Size = new Size(126, 29);
            button2.TabIndex = 3;
            button2.Text = "フォルダを選択...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Enabled = false;
            button3.Location = new Point(163, 340);
            button3.Name = "button3";
            button3.Size = new Size(154, 32);
            button3.TabIndex = 4;
            button3.Text = "選択したファイルを削除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 26);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "対象フォルダ: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Yu Gothic UI", 10F);
            groupBox1.Location = new Point(560, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 259);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "操作手順";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 21);
            label3.Name = "label3";
            label3.Size = new Size(178, 228);
            label3.TabIndex = 0;
            label3.Text = "1. ［フォルダを選択...］から\n   対象の場所を指定します。\n\n2. ［スキャン開始］を押し\n   リンク切れを抽出します。\n\n3. 消したい項目を選択して\n   ［選択したファイルを削除］\n   を押してください。\n\n※ダブルクリックで\n  元の場所を確認できます。";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(241, 25);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(528, 16);
            textBox1.TabIndex = 7;
            textBox1.Text = "(未選択)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 384);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "リンク切れスキャンツール";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
    }
}
