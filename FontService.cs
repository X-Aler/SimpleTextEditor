using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    public class FontService
    {
        public Font ChangeFontStyle(Font currentFont, FontStyle newStyle)
        {
            var updatedStyle = currentFont.Style ^ newStyle;

            return new Font(currentFont, updatedStyle);
        }

        public Font ChangeFontSize(Font currentFont, float size) => new Font(currentFont.FontFamily, size);
        public Font ChangeFontFamily(Font currentFont, Font family) => new Font(family.FontFamily, currentFont.Size);
    }
}
