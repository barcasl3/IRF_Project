using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VultronOBU
{
    public partial class LEDKijelzo : Form
    {

        public Form1 parentForm { get; set; }
        private int dispState;

        public int DisplayState
        {
            get { return dispState; }
            set {
                dispState = value;
                OnDisplayStateChange();
            }
        }


        public LEDKijelzo()
        {
            InitializeComponent();

            // https://stackoverflow.com/questions/24022411/loading-a-font-directly-from-a-file-in-c-sharp
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\temp\BUSE.ttf");
            Font font = new Font(pfc.Families[0], 72, FontStyle.Regular);
            label1.Font = font;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        public void InitKijelzo()
        {
            if(parentForm.megalloIndex == 0)
            {
                DisplayState = (int)Enums.LEDStates.Welcome;
            }
            else
            {
                DisplayState = (int)Enums.LEDStates.RouteInfo;
            }
            timer1.Start();
        }

        void OnDisplayStateChange()
        {
            switch ((Enums.LEDStates)DisplayState)
            {
                case Enums.LEDStates.Welcome:
                    {
                        label1.TextAlign = ContentAlignment.MiddleCenter;
                        label1.Text = "Köszöntjük Önöket!";
                        break;
                    }
                case Enums.LEDStates.RouteInfo:
                    {
                        label1.TextAlign = ContentAlignment.MiddleLeft;
                        label1.Text = parentForm.selectedVonat.trainnumber.ToString() + ">" + parentForm.selectedVonat.endstation;
                        break;
                    }
                case Enums.LEDStates.NextStop:
                    {
                        label1.TextAlign = ContentAlignment.MiddleCenter;
                        label1.Text = parentForm.selectedStations[parentForm.megalloIndex].stationname;
                        break;
                    }
                case Enums.LEDStates.DateTime:
                    {
                        label1.TextAlign = ContentAlignment.MiddleLeft;
                        DateTime currentDate = DateTime.Now;
                        label1.Text = currentDate.ToString("yyyy.MM.dd. HH:mm");
                        break;
                    }
                case Enums.LEDStates.Goodbye:
                    {
                        label1.TextAlign = ContentAlignment.MiddleCenter;
                        label1.Text = "Viszontlátásra!";
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DisplayState < (int)Enums.LEDStates.DateTime)
            {
                DisplayState++;
            }
            else
            {
                if (parentForm.megalloIndex == 0 && DisplayState == (int)Enums.LEDStates.DateTime)
                {
                    DisplayState = (int)Enums.LEDStates.Welcome;
                }

                else if (parentForm.megalloIndex == parentForm.selectedStations.Length - 1 && DisplayState == (int)Enums.LEDStates.DateTime)
                {
                    DisplayState = (int)Enums.LEDStates.Goodbye;
                }
                    
                else
                {
                    DisplayState = (int)Enums.LEDStates.RouteInfo;
                }
            }
        }
    }
}
