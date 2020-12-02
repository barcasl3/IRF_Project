using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace VultronOBU
{
    class VultronButton : Button
    {
        public VultronButton()
        {
            this.Width = 42;
            this.Height = 42;
            this.Font = new Font("Arial", 18, FontStyle.Bold);
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(48, 48, 48);
            this.ForeColor = Color.White;
        }
    }
}
