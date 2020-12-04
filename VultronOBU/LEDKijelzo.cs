using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VultronOBU
{
    public partial class LEDKijelzo : Form
    {

        public Form1 parentForm { get; set; }

        public LEDKijelzo()
        {
            InitializeComponent();

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        public void InitKijelzo()
        {
            label1.Text = parentForm.selectedVonat.trainnumber.ToString() + ">" + parentForm.selectedVonat.endstation;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
