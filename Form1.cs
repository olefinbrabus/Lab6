using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private string _toSavePath = string.Empty;

        private Color _colorDefalut;
        private Font _fontDefalut;


        public Form1()
        {
            InitializeComponent();

            rtxText.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtxText.Text = string.Empty;
            this.Text = "Editor - New Document";

            _colorDefalut = rtxText.ForeColor;
            _fontDefalut = rtxText.Font;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void мояДовідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyHelp help = new();
            help.ShowDialog();
        }

        private void NewFile(object sender, EventArgs e)
        {
            rtxText.Text = "";
            rtxText.ForeColor = _colorDefalut;
            rtxText.Font = _fontDefalut;
            _toSavePath = string.Empty;

        }

        private void OpenFile(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory =
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";

            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _toSavePath = openFileDialog1.FileName;
                string[] split = _toSavePath.Split(@"\");
                this.Text = "Editor - "+ split[split.Length - 1];

                using (StreamReader reader = new(_toSavePath))
                {
                    rtxText.Text = reader.ReadToEnd();
                }
            }

        }

        private void SaveFile(object sender, EventArgs e)
        {
            if(_toSavePath == string.Empty)
            {
                MessageBox.Show("Ви не обрали файл");
                return;
            }
            try
            {
                using (StreamWriter writer = new StreamWriter(_toSavePath))
                {
                    byte[] dataBytes = Encoding.UTF8.GetBytes(rtxText.Text);
                    writer.BaseStream.Write(dataBytes, 0, dataBytes.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка " + ex.Message);
            }
        }

        private void SaveAsFile(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory =
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtxText.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Fonts(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = rtxText.Font;
            fontDialog1.Color = rtxText.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                rtxText.Font = fontDialog1.Font;
                rtxText.ForeColor = fontDialog1.Color;
            }
        }

        private void Toolbox_Click(object sender, EventArgs e)
        {
            tsToolBox.Visible = !tsToolBox.Visible;
            Toolbox.Checked = tsToolBox.Visible;
        }

        private void Print(object sender, EventArgs e)
        {
            if (_toSavePath == string.Empty)
            {
                MessageBox.Show("Ви не обрали файл");
                return;
            }
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings = printDialog1.PrinterSettings;

                pd.Print();
            }
        }
    }
}
