using System.Drawing.Text;

namespace SimpleTextEditor
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
            fileText = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новыйФайлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            повторитьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            выделитьВесьТекстToolStripMenuItem = new ToolStripMenuItem();
            отменитьВыделениеToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            фонToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            панельИнструментовToolStripMenuItem = new ToolStripMenuItem();
            строкаСостоянияToolStripMenuItem = new ToolStripMenuItem();
            масштабToolStripMenuItem = new ToolStripMenuItem();
            приблизитьToolStripMenuItem = new ToolStripMenuItem();
            отдалитьToolStripMenuItem = new ToolStripMenuItem();
            стандартноеПриближениеToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            tools = new ToolStrip();
            openFileButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            createFileButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cutButton = new ToolStripButton();
            clipboardButton = new ToolStripButton();
            pasteButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            boldButton = new ToolStripButton();
            italicButton = new ToolStripButton();
            underlineButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            fontDropDown = new ToolStripDropDownButton();
            fontSizeDropDown = new ToolStripDropDownButton();
            status = new StatusStrip();
            lineStatus = new ToolStripStatusLabel();
            columnStatus = new ToolStripStatusLabel();
            symbolStatus = new ToolStripStatusLabel();
            capsStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            tools.SuspendLayout();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // fileText
            // 
            fileText.Location = new Point(0, 52);
            fileText.Name = "fileText";
            fileText.Size = new Size(784, 384);
            fileText.TabIndex = 0;
            fileText.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, форматToolStripMenuItem, видToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новыйФайлToolStripMenuItem, сохранитьКакToolStripMenuItem, сохранитьToolStripMenuItem, печатьToolStripMenuItem, выйтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйФайлToolStripMenuItem
            // 
            новыйФайлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, создатьToolStripMenuItem });
            новыйФайлToolStripMenuItem.Name = "новыйФайлToolStripMenuItem";
            новыйФайлToolStripMenuItem.Size = new Size(153, 22);
            новыйФайлToolStripMenuItem.Text = "Новый файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(121, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(121, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(153, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(153, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(153, 22);
            печатьToolStripMenuItem.Text = "Печать";
            печатьToolStripMenuItem.Click += печатьToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(153, 22);
            выйтиToolStripMenuItem.Text = "Выход";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, повторитьToolStripMenuItem, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem, выделитьВесьТекстToolStripMenuItem, отменитьВыделениеToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.Size = new Size(191, 22);
            отменитьToolStripMenuItem.Text = "Отменить";
            отменитьToolStripMenuItem.Click += отменитьToolStripMenuItem_Click;
            // 
            // повторитьToolStripMenuItem
            // 
            повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            повторитьToolStripMenuItem.Size = new Size(191, 22);
            повторитьToolStripMenuItem.Text = "Повторить";
            повторитьToolStripMenuItem.Click += повторитьToolStripMenuItem_Click;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(191, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(191, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(191, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(191, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // выделитьВесьТекстToolStripMenuItem
            // 
            выделитьВесьТекстToolStripMenuItem.Name = "выделитьВесьТекстToolStripMenuItem";
            выделитьВесьТекстToolStripMenuItem.Size = new Size(191, 22);
            выделитьВесьТекстToolStripMenuItem.Text = "Выделить все";
            выделитьВесьТекстToolStripMenuItem.Click += выделитьВесьТекстToolStripMenuItem_Click;
            // 
            // отменитьВыделениеToolStripMenuItem
            // 
            отменитьВыделениеToolStripMenuItem.Name = "отменитьВыделениеToolStripMenuItem";
            отменитьВыделениеToolStripMenuItem.Size = new Size(191, 22);
            отменитьВыделениеToolStripMenuItem.Text = "Отменить выделение";
            отменитьВыделениеToolStripMenuItem.Click += отменитьВыделениеToolStripMenuItem_Click;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { шрифтToolStripMenuItem, фонToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(62, 20);
            форматToolStripMenuItem.Text = "Формат";
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(180, 22);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // фонToolStripMenuItem
            // 
            фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            фонToolStripMenuItem.Size = new Size(180, 22);
            фонToolStripMenuItem.Text = "Фон";
            фонToolStripMenuItem.Click += фонToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { панельИнструментовToolStripMenuItem, строкаСостоянияToolStripMenuItem, масштабToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // панельИнструментовToolStripMenuItem
            // 
            панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            панельИнструментовToolStripMenuItem.Size = new Size(196, 22);
            панельИнструментовToolStripMenuItem.Text = "Панель инструментов";
            панельИнструментовToolStripMenuItem.Click += панельИнструментовToolStripMenuItem_Click;
            // 
            // строкаСостоянияToolStripMenuItem
            // 
            строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
            строкаСостоянияToolStripMenuItem.Size = new Size(196, 22);
            строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
            строкаСостоянияToolStripMenuItem.Click += строкаСостоянияToolStripMenuItem_Click;
            // 
            // масштабToolStripMenuItem
            // 
            масштабToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { приблизитьToolStripMenuItem, отдалитьToolStripMenuItem, стандартноеПриближениеToolStripMenuItem });
            масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            масштабToolStripMenuItem.Size = new Size(196, 22);
            масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // приблизитьToolStripMenuItem
            // 
            приблизитьToolStripMenuItem.Name = "приблизитьToolStripMenuItem";
            приблизитьToolStripMenuItem.Size = new Size(224, 22);
            приблизитьToolStripMenuItem.Text = "Приблизить";
            приблизитьToolStripMenuItem.Click += приблизитьToolStripMenuItem_Click;
            // 
            // отдалитьToolStripMenuItem
            // 
            отдалитьToolStripMenuItem.Name = "отдалитьToolStripMenuItem";
            отдалитьToolStripMenuItem.Size = new Size(224, 22);
            отдалитьToolStripMenuItem.Text = "Отдалить";
            отдалитьToolStripMenuItem.Click += отдалитьToolStripMenuItem_Click;
            // 
            // стандартноеПриближениеToolStripMenuItem
            // 
            стандартноеПриближениеToolStripMenuItem.Name = "стандартноеПриближениеToolStripMenuItem";
            стандартноеПриближениеToolStripMenuItem.Size = new Size(224, 22);
            стандартноеПриближениеToolStripMenuItem.Text = "Стандартное приближение";
            стандартноеПриближениеToolStripMenuItem.Click += стандартноеПриближениеToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, помощьToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(149, 22);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // tools
            // 
            tools.Items.AddRange(new ToolStripItem[] { openFileButton, saveButton, createFileButton, toolStripSeparator1, cutButton, clipboardButton, pasteButton, toolStripSeparator2, boldButton, italicButton, underlineButton, toolStripSeparator3, fontDropDown, fontSizeDropDown });
            tools.Location = new Point(0, 24);
            tools.Name = "tools";
            tools.Padding = new Padding(0);
            tools.Size = new Size(784, 25);
            tools.TabIndex = 2;
            tools.Text = "toolStrip1";
            // 
            // openFileButton
            // 
            openFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openFileButton.Image = (Image)resources.GetObject("openFileButton.Image");
            openFileButton.ImageTransparentColor = Color.Magenta;
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(23, 22);
            openFileButton.Text = "toolStripButton2";
            openFileButton.Click += openFileButton_Click;
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.ImageTransparentColor = Color.Magenta;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(23, 22);
            saveButton.Text = "saveButton";
            saveButton.Click += saveButton_Click;
            // 
            // createFileButton
            // 
            createFileButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            createFileButton.Image = (Image)resources.GetObject("createFileButton.Image");
            createFileButton.ImageTransparentColor = Color.Magenta;
            createFileButton.Name = "createFileButton";
            createFileButton.Size = new Size(23, 22);
            createFileButton.Text = "toolStripButton3";
            createFileButton.Click += createFileButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // cutButton
            // 
            cutButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutButton.Image = (Image)resources.GetObject("cutButton.Image");
            cutButton.ImageTransparentColor = Color.Magenta;
            cutButton.Name = "cutButton";
            cutButton.Size = new Size(23, 22);
            cutButton.Text = "toolStripButton1";
            cutButton.Click += cutButton_Click;
            // 
            // clipboardButton
            // 
            clipboardButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            clipboardButton.Image = (Image)resources.GetObject("clipboardButton.Image");
            clipboardButton.ImageTransparentColor = Color.Magenta;
            clipboardButton.Name = "clipboardButton";
            clipboardButton.Size = new Size(23, 22);
            clipboardButton.Text = "toolStripButton4";
            clipboardButton.Click += clipboardButton_Click;
            // 
            // pasteButton
            // 
            pasteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteButton.Image = (Image)resources.GetObject("pasteButton.Image");
            pasteButton.ImageTransparentColor = Color.Magenta;
            pasteButton.Name = "pasteButton";
            pasteButton.Size = new Size(23, 22);
            pasteButton.Text = "toolStripButton5";
            pasteButton.Click += pasteButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // boldButton
            // 
            boldButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            boldButton.Image = (Image)resources.GetObject("boldButton.Image");
            boldButton.ImageTransparentColor = Color.Magenta;
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(23, 22);
            boldButton.Text = "B";
            boldButton.Click += boldButton_Click;
            // 
            // italicButton
            // 
            italicButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            italicButton.Image = (Image)resources.GetObject("italicButton.Image");
            italicButton.ImageTransparentColor = Color.Magenta;
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(23, 22);
            italicButton.Text = "I";
            italicButton.Click += italicButton_Click;
            // 
            // underlineButton
            // 
            underlineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            underlineButton.Image = (Image)resources.GetObject("underlineButton.Image");
            underlineButton.ImageTransparentColor = Color.Magenta;
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(23, 22);
            underlineButton.Text = "U";
            underlineButton.Click += underlineButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // fontDropDown
            // 
            fontDropDown.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fontDropDown.Image = (Image)resources.GetObject("fontDropDown.Image");
            fontDropDown.ImageTransparentColor = Color.Magenta;
            fontDropDown.Name = "fontDropDown";
            fontDropDown.Size = new Size(44, 22);
            fontDropDown.Text = "Arial";
            fontDropDown.DropDownItemClicked += fontDropDown_DropDownItemClicked;
            // 
            // fontSizeDropDown
            // 
            fontSizeDropDown.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fontSizeDropDown.Image = (Image)resources.GetObject("fontSizeDropDown.Image");
            fontSizeDropDown.ImageTransparentColor = Color.Magenta;
            fontSizeDropDown.Name = "fontSizeDropDown";
            fontSizeDropDown.Size = new Size(32, 22);
            fontSizeDropDown.Text = "12";
            fontSizeDropDown.DropDownItemClicked += fontSizeDropDown_DropDownItemClicked;
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { lineStatus, columnStatus, symbolStatus, capsStatus });
            status.Location = new Point(0, 439);
            status.Name = "status";
            status.Size = new Size(784, 22);
            status.TabIndex = 3;
            status.Text = "statusStrip1";
            // 
            // lineStatus
            // 
            lineStatus.Name = "lineStatus";
            lineStatus.Size = new Size(61, 17);
            lineStatus.Text = "Строка 10";
            // 
            // columnStatus
            // 
            columnStatus.Name = "columnStatus";
            columnStatus.Size = new Size(69, 17);
            columnStatus.Text = "Столбец 25";
            // 
            // symbolStatus
            // 
            symbolStatus.Name = "symbolStatus";
            symbolStatus.Size = new Size(94, 17);
            symbolStatus.Text = "Символов: 1245";
            // 
            // capsStatus
            // 
            capsStatus.Name = "capsStatus";
            capsStatus.Size = new Size(67, 17);
            capsStatus.Text = "CAPS NUM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(status);
            Controls.Add(tools);
            Controls.Add(fileText);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Simple Text Editor";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tools.ResumeLayout(false);
            tools.PerformLayout();
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox fileText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новыйФайлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem выделитьВесьТекстToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem отменитьВыделениеToolStripMenuItem;
        private ToolStrip tools;
        private ToolStripButton saveButton;
        private ToolStripButton openFileButton;
        private ToolStripButton createFileButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton cutButton;
        private ToolStripButton clipboardButton;
        private ToolStripButton pasteButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton boldButton;
        private ToolStripButton italicButton;
        private ToolStripButton underlineButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton fontDropDown;
        private ToolStripDropDownButton fontSizeDropDown;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private StatusStrip status;
        private ToolStripStatusLabel lineStatus;
        private ToolStripStatusLabel columnStatus;
        private ToolStripStatusLabel symbolStatus;
        private ToolStripStatusLabel capsStatus;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem повторитьToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem фонToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem панельИнструментовToolStripMenuItem;
        private ToolStripMenuItem строкаСостоянияToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem приблизитьToolStripMenuItem;
        private ToolStripMenuItem отдалитьToolStripMenuItem;
        private ToolStripMenuItem стандартноеПриближениеToolStripMenuItem;
    }
}
