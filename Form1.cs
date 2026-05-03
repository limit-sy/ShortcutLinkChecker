using IWshRuntimeLibrary; // ショートカット解析用
using System.IO;          // ファイル操作用

namespace ShortcutLinkChecker

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string targetPath = textBox1.Text;

            // パスが空、または存在しない場合は中断
            if (string.IsNullOrEmpty(targetPath) || !Directory.Exists(targetPath))
            {
                MessageBox.Show("有効なフォルダを選択してください。");
                return;
            }

            listBox1.Items.Clear(); // リストを初期化
            WshShell shell = new WshShell();

            try
            {
                // フォルダ内の .lnk ファイルをすべて取得
                string[] files = Directory.GetFiles(targetPath, "*.lnk", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    // ショートカット情報を読み込む
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(file);
                    string linkPath = shortcut.TargetPath;

                    // リンク先のパスが「ファイル」としても「フォルダ」としても存在しない場合
                    if (!System.IO.File.Exists(linkPath) && !System.IO.Directory.Exists(linkPath))
                    {
                        // Path.GetFileName を外して、フルパス(file)をそのまま追加する
                        listBox1.Items.Add(file);
                    }
                }

                // リストボックス内の項目の幅に合わせてスクロール範囲を調整
                int maxWidth = 0;
                using (Graphics g = listBox1.CreateGraphics())
                {
                    foreach (var item in listBox1.Items)
                    {
                        int itemWidth = (int)g.MeasureString(item.ToString(), listBox1.Font).Width;
                        if (itemWidth > maxWidth) maxWidth = itemWidth;
                    }
                }
                // 実際の幅より少し余裕を持たせて設定
                listBox1.HorizontalExtent = maxWidth + 20;

                MessageBox.Show("スキャンが完了しました");
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーが発生しました: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                // ダイアログの説明文
                fbd.Description = "スキャンするフォルダを選択してください。";
                // 最初に表示するフォルダ（任意）
                fbd.RootFolder = Environment.SpecialFolder.Desktop;

                // ダイアログを表示し、[OK]が押されたら
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // 選択されたフォルダパスをラベルに表示する
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 選択されている項目の数をチェック
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("削除するファイルを選択してください。");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"{listBox1.SelectedItems.Count} 件のファイルを削除しますか?",
                "一括削除確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 選択されている項目を「後ろから順番に」ループして削除する
                    // ※前から消すと、消した瞬間にインデックスがズレてエラーになるため
                    for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        int index = listBox1.SelectedIndices[i];
                        // ここがフルパスになっているので、そのまま使えます
                        string filePath = listBox1.Items[index].ToString();

                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Delete(filePath);
                        }
                        listBox1.Items.RemoveAt(index);
                    }

                    MessageBox.Show("削除が完了しました。");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("一部のファイルの削除に失敗しました: " + ex.Message);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            // リスト内の項目がすでにフルパスなので、そのまま代入
            string filePath = listBox1.SelectedItem.ToString();

            if (System.IO.File.Exists(filePath))
            {
                string argument = "/select, \"" + filePath + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
        }
    }
}
