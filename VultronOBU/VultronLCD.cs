using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.IO;

namespace VultronOBU
{
    class VultronLCD : RichTextBox
    {
        public VultronLCD()
        {
            this.Width = 196;
            this.Height = 73;
            this.Multiline = true;
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.Black;
            this.ForeColor = Color.FromArgb(255, 194, 0);
            this.ReadOnly = true;
            this.FontHeight = 4;

            // https://stackoverflow.com/questions/24022411/loading-a-font-directly-from-a-file-in-c-sharp
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\temp\LcdSolid-VPzB.ttf");
            Font font = new Font(pfc.Families[0], 10, FontStyle.Regular);

            this.Font = font;
        }
    }
}
