using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Editor
{
    public static class EditorUtilities
    {
        public static Color GetGrayColor(Color c)
        {
            int gray = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
            return Color.FromArgb(gray, gray, gray);
        }

        public static Color GetWhiteOrBlackColor(Color c)
        {
            int gray = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
            if (gray > 128)
            {
                gray = 255;
            }
            else
            {
                gray = 0;
            }
            return Color.FromArgb(gray, gray, gray);
        }
    }
}
