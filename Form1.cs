using System.Drawing.Printing;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        private const string SAVE_NOTE = "Примечание: если вы не сохранили изменения они пропадут!";

        private const string APP_NAME = "Simple Text Editor";
        private string? CurrentFilePath { get; set; }

        private PrintDocument printDocument = new PrintDocument();

        private FontDialog fontDialog = new FontDialog();

        private FileService fileService = new FileService();

        private ZoomService zoomService = new ZoomService();

        private FontService fontService = new FontService();

        private StatusService statusService = new StatusService();

        public Form1()
        {
            InitializeComponent();
            InitFontDropDowns();
            UpdateCapsDisplay();
            UpdateStatus();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            printDocument.PrintPage += printDocument_PrintPage;
            fileText.TextChanged += (s, e) => UpdateStatus();
            fileText.SelectionChanged += (s, e) => UpdateStatus();
            fileText.SelectionChanged += (s, e) => FontChangedEvent();
            fileText.FontChanged += (s, e) => FontChangedEvent();
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

            FontChangedEvent();
        }

        private void UpdateStatus()
        {
            var (row, column, symbols) = statusService.GetStatus(fileText);

            lineStatus.Text = $"Строка: {row}";

            columnStatus.Text = $"Столбец: {column}";

            symbolStatus.Text = $"Символов: {symbols}";
        }

        private void UpdateCapsDisplay() => capsStatus.Text = statusService.GetCapsDisplay(IsKeyLocked(Keys.CapsLock));

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e) => NewFile();

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) => Save();

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e) => Save();

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) => OpenFile();

        private void UpdateAppName() => Text = $"{APP_NAME} {Path.GetFileName(CurrentFilePath)}";

        private void выделитьВесьТекстToolStripMenuItem_Click(object sender, EventArgs e) => fileText.SelectAll();

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.Cut();

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.Copy();

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.Paste();

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.SelectedText = "";

        private void отменитьВыделениеToolStripMenuItem_Click(object sender, EventArgs e) => fileText.DeselectAll();

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.Undo();

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e) => ChangeVisible(tools);

        private void строкаСостоянияToolStripMenuItem_Click(object sender, EventArgs e) => ChangeVisible(status);

        private void ChangeVisible(Control control) => control.Visible = !control.Visible;

        private void приблизитьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.ZoomFactor = zoomService.Increase(fileText.ZoomFactor);

        private void отдалитьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.ZoomFactor = zoomService.Decrease(fileText.ZoomFactor);

        private void стандартноеПриближениеToolStripMenuItem_Click(object sender, EventArgs e) => fileText.ZoomFactor = zoomService.Reset();

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e) => fileText.AppendText(fileText.SelectedText);

        private void openFileButton_Click(object sender, EventArgs e) => OpenFile();

        private void saveButton_Click(object sender, EventArgs e) => Save();

        private void createFileButton_Click(object sender, EventArgs e) => NewFile();

        private void cutButton_Click(object sender, EventArgs e) => fileText.Cut();

        private void clipboardButton_Click(object sender, EventArgs e) => fileText.Copy();

        private void pasteButton_Click(object sender, EventArgs e) => fileText.Paste();

        private void boldButton_Click(object sender, EventArgs e) => ChangeFontStyle(FontStyle.Bold);

        private void italicButton_Click(object sender, EventArgs e) => ChangeFontStyle(FontStyle.Italic);

        private void underlineButton_Click(object sender, EventArgs e) => ChangeFontStyle(FontStyle.Underline);

        private void фонToolStripMenuItem_Click(object sender, EventArgs e) => ChangeColor(c => fileText.BackColor = c);

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e) => ChangeColor(c => fileText.ForeColor = c);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = MessageBox.Show($"Вы точно хотите выйти? \n{SAVE_NOTE}",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.No)
                e.Cancel = true;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileText.SelectionFont == null)
                fontDialog.Font = fileText.Font;
            else
                fontDialog.Font = fileText.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fileText.SelectionFont = fontDialog.Font;
            }
        }

        private void fontDropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var currentFont = fileText.SelectionFont;

            if (currentFont != null)
            {
                var newFont = new Font(e.ClickedItem.Text, currentFont.Size);

                fileText.SelectionFont = fontService.ChangeFontFamily(currentFont, newFont);
                MessageBox.Show("Шрифт изменен!");
            }

        }

        private void fontSizeDropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var currentFont = fileText.SelectionFont;

            var size = float.Parse(e.ClickedItem.Text);

            if (currentFont != null)
                fileText.SelectionFont = fontService.ChangeFontSize(currentFont, size);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
                UpdateCapsDisplay();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();

            ppd.Document = printDocument;
            ppd.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(fileText.Text, fileText.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);

            e.HasMorePages = false;
        }

        private void ChangeColor(Action<Color> setColor)
        {
            var colorDialogue = new ColorDialog();

            if (colorDialogue.ShowDialog() == DialogResult.OK)
                setColor(colorDialogue.Color);
        }

        private void ChangeFontStyle(FontStyle style)
        {
            var currentFont = fileText.SelectionFont;

            if (currentFont != null)
                fileText.SelectionFont = fontService.ChangeFontStyle(currentFont, style);
        }

        private void FontChangedEvent()
        {
            var currentFont = fileText.SelectionFont ?? fileText.Font;

            fontDropDown.Text = currentFont.Name;
            fontSizeDropDown.Text = currentFont.Size.ToString();
            fontDialog.Font = currentFont;
        }

        private void NewFile()
        {
            var message = MessageBox.Show($"Вы точно хотите создать новый файл? \n{SAVE_NOTE}",
"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (message == DialogResult.Yes)
            {
                CurrentFilePath = null;
                fileText.Clear();
                MessageBox.Show("Файл успешно создан!");
            }
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                var saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Выберит путь файла";
                saveFileDialog.Filter = "RTF файлы (*.rtf)|*.rtf|Текстовые файлы (*.txt)|*.txt";
                saveFileDialog.FileName = Path.GetFileName(CurrentFilePath);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = saveFileDialog.FileName;
                    UpdateAppName();
                }
                else return;
            }

            fileService.SaveFile(fileText, CurrentFilePath);
        }


        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "RTF файлы (*.rtf)|*.rtf|Текстовые файлы (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                CurrentFilePath = path;

                fileService.LoadFile(fileText, path);

                UpdateAppName();
            }
        }
    }
}

