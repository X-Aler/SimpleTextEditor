using System.Diagnostics;
using System.Drawing.Printing;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        private string saveNote = "Примечание: если вы не сохранили изменения они пропадут!";
        private string appName = "Simple Text Editor";
        public string CurrentFilePath { get; private set; }

        private PrintDocument printDocument = new PrintDocument();

        private FontDialog fontDialog = new FontDialog();

        private float maxZoom = 10f;
        private float minZoom = 10f;
        private float baseZoom = 1f;
        private float zoomChangeStep = 0.1f;

        public Form1()
        {
            InitializeComponent();
            InitFontDropDowns();
            UpdateCapsDisplay();
            UpdateStatus();

            KeyPreview = true;
            printDocument.PrintPage += printDocument_PrintPage;
            fileText.TextChanged += (s,e) => UpdateStatus();
            fileText.SelectionChanged += (s,e) => UpdateStatus();
        }

        private void InitFontDropDowns()
        {
            var fontNames = FontFamily.Families.Select(f => f.Name);
            var sizes = Enumerable.Range(1, 72).ToArray();

            foreach (var name in fontNames)
            {
                var item = new ToolStripMenuItem(name);

                item.Click += (s, e) => { fontDropDown.Text = item.Text; };

                fontDropDown.DropDownItems.Add(item);
            }

            foreach (var size in sizes)
            {
                var item = new ToolStripMenuItem(size.ToString());

                item.Click += (s, e) => { fontSizeDropDown.Text = item.Text; };

                fontSizeDropDown.DropDownItems.Add(item);
            }

            FontChangedEvent(null, new EventArgs());

            fileText.FontChanged += FontChangedEvent;
        }

        private void UpdateStatus()
        {
            var index = fileText.SelectionStart;
            var currentRow = fileText.GetLineFromCharIndex(index);
            lineStatus.Text = $"Строка: {currentRow}";

            var linestart = fileText.GetFirstCharIndexOfCurrentLine();
            var currentcolumn = index - linestart + 1;
            columnStatus.Text = $"Столбец: {currentcolumn}";

            symbolStatus.Text = $"Символов: {fileText.TextLength}";
        }

        private void UpdateCapsDisplay()
        {
            bool isCapsOn = Control.IsKeyLocked(Keys.CapsLock);

            capsStatus.Text = isCapsOn ? "CAPS ON" : "caps off";
        }
        private void FontChangedEvent(object sender, EventArgs e)
        {
            fontDropDown.Text = fileText.Font.Name;
            fontSizeDropDown.Text = fileText.Font.Size.ToString();
            fontDialog.Font = fileText.Font;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(fileText.Text, fileText.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);

            e.HasMorePages = false;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void NewFile()
        {
            var message = MessageBox.Show($"Вы точно хотите создать новый файл? \n{saveNote}",
        "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                CurrentFilePath = null;
                fileText.Clear();

                MessageBox.Show("Файл успешно создан!");
            }
        }

        private void CreateFile(string fileDirectory)
        {
            CurrentFilePath = fileDirectory;

            Save();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (CurrentFilePath == null)
            {
                SaveAs();
                return;
            }

            var ext = Path.GetExtension(CurrentFilePath);

            if (ext == ".rtf")
            {
                fileText.SaveFile(CurrentFilePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                fileText.SaveFile(CurrentFilePath, RichTextBoxStreamType.PlainText);
            }

            UpdateText();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Выберит путь файла";
            saveFileDialog.Filter = "RTF файлы (*.rtf)|*.rtf|Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.FileName = Path.GetFileName(CurrentFilePath);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;

                CreateFile(path);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = MessageBox.Show($"Вы точно хотите выйти? \n{saveNote}",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "RTF файлы (*.rtf)|*.rtf|Текстовые файлы (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = openFileDialog.FileName;

                UpdateText();
            }
        }

        private void UpdateText()
        {
            try
            {
                var ext = Path.GetExtension(CurrentFilePath);

                if (ext == ".rtf")
                    fileText.LoadFile(CurrentFilePath, RichTextBoxStreamType.RichText);
                else if (ext == ".txt")
                    fileText.LoadFile(CurrentFilePath, RichTextBoxStreamType.PlainText);
            }
            catch
            {
                fileText.LoadFile(CurrentFilePath, RichTextBoxStreamType.PlainText);
            }

            Text = $"{appName} {Path.GetFileName(CurrentFilePath)}";
        }

        private void выделитьВесьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.SelectAll();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.Paste();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.SelectedText = "";
        }

        private void отменитьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.DeselectAll();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fileText.SelectionFont == null)
                fontDialog.Font = fileText.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fileText.SelectionFont = fontDialog.Font;
            }
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.Undo();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();

            ppd.Document = printDocument;
            ppd.ShowDialog();
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeVisible(tools);
        }

        private void строкаСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeVisible(status);
        }

        private void ChangeVisible(Control control)
        {
            control.Visible = !control.Visible;
        }

        private void приблизитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileText.ZoomFactor < maxZoom)
                fileText.ZoomFactor += zoomChangeStep;
        }

        private void отдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileText.ZoomFactor > minZoom)
                fileText.ZoomFactor -= zoomChangeStep;
        }

        private void стандартноеПриближениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.ZoomFactor = baseZoom;
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorDialogue = new ColorDialog();

            if (colorDialogue.ShowDialog() == DialogResult.OK)
                fileText.BackColor = colorDialogue.Color;
        }

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileText.AppendText(fileText.SelectedText);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            fileText.Cut();

        }

        private void clipboardButton_Click(object sender, EventArgs e)
        {
            fileText.Copy();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            fileText.Paste();
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }
        private void underlineButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline);
        }

        private void ChangeFontStyle(FontStyle newStyle)
        {

            var currentFont = fileText.SelectionFont ?? fileText.Font;

            var updatedStyle = currentFont.Style ^ newStyle;
            fileText.SelectionFont = new Font(currentFont, updatedStyle);
        }
        private void fontDropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var currentFont = fileText.SelectionFont;

            if (currentFont != null)
                fileText.SelectionFont = new Font(e.ClickedItem.Text, currentFont.Size);
        }

        private void fontSizeDropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var currentFont = fileText.SelectionFont;

            float size = float.Parse(e.ClickedItem.Text);

            if (currentFont != null)
                fileText.SelectionFont = new Font(currentFont.FontFamily, size);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
                UpdateCapsDisplay();
        }
    }
}

