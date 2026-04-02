using System.Text;
namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        private string saveNote = "Примечание: если вы не сохранили изменения они пропадут!";
        private string appName = "Simple Text Editor";
        public string CurrentFilePath { get; private set; }

        private FontDialog fontDialog = new FontDialog();

        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }


        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
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
            File.WriteAllText(fileDirectory, fileText.Text, Encoding.GetEncoding(1251));

            CurrentFilePath = fileDirectory;

            UpdateText();
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

            File.WriteAllText(CurrentFilePath, fileText.Text, Encoding.GetEncoding(1251));
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
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
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
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = openFileDialog.FileName;

                UpdateText();
            }
        }

        private void UpdateText()
        {
            fileText.Text = File.ReadAllText(CurrentFilePath, Encoding.GetEncoding(1251));
            Text = $"{appName} {Path.GetFileName(CurrentFilePath)}"; ;
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

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorDialogue = new ColorDialog();

            if (colorDialogue.ShowDialog() == DialogResult.OK)
                fileText.BackColor = colorDialogue.Color;
        }
    }
}
