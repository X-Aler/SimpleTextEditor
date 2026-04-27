using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace SimpleTextEditor
{
    public class StatusService
    {
        public (int Row, int Column, int Symbols) GetStatus(RichTextBox text)
        {
            var index = text.SelectionStart;
            var row = text.GetLineFromCharIndex(index);

            var linestart = text.GetFirstCharIndexOfCurrentLine();
            var column = index - linestart + 1;

            return (row, column, text.TextLength);
        }
        public string GetCapsDisplay(bool isCapsOn)
        {
            return isCapsOn ? "CAPS ON" : "caps off";
        }
    }
}
