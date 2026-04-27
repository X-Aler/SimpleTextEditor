namespace SimpleTextEditor
{
    public class FileService
    {
        public void SaveFile(RichTextBox text, string path) => text.SaveFile(path, GetStreamType(path));

        public void LoadFile(RichTextBox text, string path) => text.LoadFile(path, GetStreamType(path));

        private RichTextBoxStreamType GetStreamType(string path)
        {
            return Path.GetExtension(path) == ".rtf" 
                ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
        }
    }
}
