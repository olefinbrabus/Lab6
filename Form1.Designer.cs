namespace Lab6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            tsmiFile = new ToolStripMenuItem();
            новийToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem1 = new ToolStripMenuItem();
            друкуватиToolStripMenuItem = new ToolStripMenuItem();
            попереднійПерглядToolStripMenuItem = new ToolStripMenuItem();
            параметриСторінкиToolStripMenuItem = new ToolStripMenuItem();
            вихідToolStripMenuItem = new ToolStripMenuItem();
            панельІнструментівToolStripMenuItem = new ToolStripMenuItem();
            tsmiPreferences = new ToolStripMenuItem();
            Toolbox = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            tsmiHelp = new ToolStripMenuItem();
            мояДовідкаToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            rtxText = new RichTextBox();
            tsToolBox = new ToolStrip();
            создатьToolStripButton = new ToolStripButton();
            открытьToolStripButton = new ToolStripButton();
            сохранитьToolStripButton = new ToolStripButton();
            печатьToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            справкаToolStripButton = new ToolStripButton();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            menuStrip1.SuspendLayout();
            tsToolBox.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile, панельІнструментівToolStripMenuItem, tsmiPreferences, tsmiHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            tsmiFile.DropDownItems.AddRange(new ToolStripItem[] { новийToolStripMenuItem, відкритиToolStripMenuItem, зберегтиЯкToolStripMenuItem, зберегтиЯкToolStripMenuItem1, вихідToolStripMenuItem });
            tsmiFile.Name = "tsmiFile";
            tsmiFile.Size = new Size(48, 20);
            tsmiFile.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            новийToolStripMenuItem.ShortcutKeyDisplayString = "";
            новийToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            новийToolStripMenuItem.Size = new Size(180, 22);
            новийToolStripMenuItem.Text = "Новий";
            новийToolStripMenuItem.Click += NewFile;
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            відкритиToolStripMenuItem.Size = new Size(180, 22);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += OpenFile;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            зберегтиЯкToolStripMenuItem.Size = new Size(180, 22);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти";
            зберегтиЯкToolStripMenuItem.Click += SaveFile;
            // 
            // зберегтиЯкToolStripMenuItem1
            // 
            зберегтиЯкToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { друкуватиToolStripMenuItem, попереднійПерглядToolStripMenuItem, параметриСторінкиToolStripMenuItem });
            зберегтиЯкToolStripMenuItem1.Name = "зберегтиЯкToolStripMenuItem1";
            зберегтиЯкToolStripMenuItem1.Size = new Size(180, 22);
            зберегтиЯкToolStripMenuItem1.Text = "Зберегти як";
            зберегтиЯкToolStripMenuItem1.Click += SaveAsFile;
            // 
            // друкуватиToolStripMenuItem
            // 
            друкуватиToolStripMenuItem.Name = "друкуватиToolStripMenuItem";
            друкуватиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            друкуватиToolStripMenuItem.Size = new Size(187, 22);
            друкуватиToolStripMenuItem.Text = "Друкувати";
            друкуватиToolStripMenuItem.Click += Print;
            // 
            // попереднійПерглядToolStripMenuItem
            // 
            попереднійПерглядToolStripMenuItem.Name = "попереднійПерглядToolStripMenuItem";
            попереднійПерглядToolStripMenuItem.Size = new Size(187, 22);
            попереднійПерглядToolStripMenuItem.Text = "Попередній пергляд";
            // 
            // параметриСторінкиToolStripMenuItem
            // 
            параметриСторінкиToolStripMenuItem.Name = "параметриСторінкиToolStripMenuItem";
            параметриСторінкиToolStripMenuItem.Size = new Size(187, 22);
            параметриСторінкиToolStripMenuItem.Text = "Параметри сторінки";
            // 
            // вихідToolStripMenuItem
            // 
            вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            вихідToolStripMenuItem.Size = new Size(180, 22);
            вихідToolStripMenuItem.Text = "Вихід";
            вихідToolStripMenuItem.Click += вихідToolStripMenuItem_Click;
            // 
            // панельІнструментівToolStripMenuItem
            // 
            панельІнструментівToolStripMenuItem.Name = "панельІнструментівToolStripMenuItem";
            панельІнструментівToolStripMenuItem.Size = new Size(12, 20);
            // 
            // tsmiPreferences
            // 
            tsmiPreferences.DropDownItems.AddRange(new ToolStripItem[] { Toolbox, шрифтToolStripMenuItem });
            tsmiPreferences.Name = "tsmiPreferences";
            tsmiPreferences.Size = new Size(81, 20);
            tsmiPreferences.Text = "Параметри";
            // 
            // Toolbox
            // 
            Toolbox.Name = "Toolbox";
            Toolbox.Size = new Size(188, 22);
            Toolbox.Text = "Панель Інструментів";
            Toolbox.Click += Toolbox_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            шрифтToolStripMenuItem.Size = new Size(188, 22);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += Fonts;
            // 
            // tsmiHelp
            // 
            tsmiHelp.DropDownItems.AddRange(new ToolStripItem[] { мояДовідкаToolStripMenuItem, проПрограмуToolStripMenuItem });
            tsmiHelp.Name = "tsmiHelp";
            tsmiHelp.Size = new Size(75, 20);
            tsmiHelp.Text = "Допомога";
            // 
            // мояДовідкаToolStripMenuItem
            // 
            мояДовідкаToolStripMenuItem.Name = "мояДовідкаToolStripMenuItem";
            мояДовідкаToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            мояДовідкаToolStripMenuItem.Size = new Size(187, 22);
            мояДовідкаToolStripMenuItem.Text = "Моя довідка ";
            мояДовідкаToolStripMenuItem.Click += мояДовідкаToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(187, 22);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // rtxText
            // 
            rtxText.Dock = DockStyle.Fill;
            rtxText.Location = new Point(0, 24);
            rtxText.Name = "rtxText";
            rtxText.Size = new Size(800, 426);
            rtxText.TabIndex = 1;
            rtxText.Text = "";
            // 
            // tsToolBox
            // 
            tsToolBox.Items.AddRange(new ToolStripItem[] { создатьToolStripButton, открытьToolStripButton, сохранитьToolStripButton, печатьToolStripButton, toolStripSeparator, справкаToolStripButton });
            tsToolBox.Location = new Point(0, 24);
            tsToolBox.Name = "tsToolBox";
            tsToolBox.Size = new Size(800, 25);
            tsToolBox.TabIndex = 2;
            tsToolBox.Text = "toolStrip1";
            // 
            // создатьToolStripButton
            // 
            создатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            создатьToolStripButton.Image = (Image)resources.GetObject("создатьToolStripButton.Image");
            создатьToolStripButton.ImageTransparentColor = Color.Magenta;
            создатьToolStripButton.Name = "создатьToolStripButton";
            создатьToolStripButton.Size = new Size(23, 22);
            создатьToolStripButton.Text = "&Создать";
            создатьToolStripButton.Click += NewFile;
            // 
            // открытьToolStripButton
            // 
            открытьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            открытьToolStripButton.Image = (Image)resources.GetObject("открытьToolStripButton.Image");
            открытьToolStripButton.ImageTransparentColor = Color.Magenta;
            открытьToolStripButton.Name = "открытьToolStripButton";
            открытьToolStripButton.Size = new Size(23, 22);
            открытьToolStripButton.Text = "&Открыть";
            открытьToolStripButton.Click += OpenFile;
            // 
            // сохранитьToolStripButton
            // 
            сохранитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            сохранитьToolStripButton.Image = (Image)resources.GetObject("сохранитьToolStripButton.Image");
            сохранитьToolStripButton.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            сохранитьToolStripButton.Size = new Size(23, 22);
            сохранитьToolStripButton.Text = "&Сохранить";
            сохранитьToolStripButton.Click += SaveFile;
            // 
            // печатьToolStripButton
            // 
            печатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            печатьToolStripButton.Image = (Image)resources.GetObject("печатьToolStripButton.Image");
            печатьToolStripButton.ImageTransparentColor = Color.Magenta;
            печатьToolStripButton.Name = "печатьToolStripButton";
            печатьToolStripButton.Size = new Size(23, 22);
            печатьToolStripButton.Text = "&Печать";
            печатьToolStripButton.Click += Print;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // справкаToolStripButton
            // 
            справкаToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            справкаToolStripButton.Image = (Image)resources.GetObject("справкаToolStripButton.Image");
            справкаToolStripButton.ImageTransparentColor = Color.Magenta;
            справкаToolStripButton.Name = "справкаToolStripButton";
            справкаToolStripButton.Size = new Size(23, 22);
            справкаToolStripButton.Text = "С&правка";
            справкаToolStripButton.Click += мояДовідкаToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tsToolBox);
            Controls.Add(rtxText);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tsToolBox.ResumeLayout(false);
            tsToolBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private RichTextBox rtxText;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem новийToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem1;
        private ToolStripMenuItem друкуватиToolStripMenuItem;
        private ToolStripMenuItem попереднійПерглядToolStripMenuItem;
        private ToolStripMenuItem параметриСторінкиToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
        private ToolStripMenuItem панельІнструментівToolStripMenuItem;
        private ToolStripMenuItem tsmiPreferences;
        private ToolStripMenuItem Toolbox;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem мояДовідкаToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStrip tsToolBox;
        private ToolStripButton создатьToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripButton печатьToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton справкаToolStripButton;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
    }
}
