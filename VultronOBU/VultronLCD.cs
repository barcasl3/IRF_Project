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
    class VultronLCD : TextBox
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

            // TODO: font beállítása
        }
    }
}
