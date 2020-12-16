using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace VultronOBU
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        //int currentState = (int)Enums.States.Startup;
        private int currState;

        public int currentState
        {
            get { return currState; }
            set { 
                currState = value;
                OnStateChange(currState);
            }
        }

        public int currentJaratszam = -1;
        public int currentCarNumber = -1;
        public Trains selectedVonat;
        public Stations[] selectedStations;
        public int megalloIndex = 0;
        
        LEDKijelzo led = new LEDKijelzo();
        Database1Entities context = new Database1Entities();

        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            Setup();
            SetEventHandlers();
            led.parentForm = this;

            led.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            led.StartPosition = FormStartPosition.Manual;
            led.Show();
        }

        void Setup()
        {
            this.currentState = (int)Enums.States.Startup;
            timer1.Interval = 1000;
        }

        void SetEventHandlers()
        {
            btn_Num1.Click += Btn_Num_Click;
            btn_Num2.Click += Btn_Num_Click;
            btn_Num3.Click += Btn_Num_Click;
            btn_Num4.Click += Btn_Num_Click;
            btn_Num5.Click += Btn_Num_Click;
            btn_Num6.Click += Btn_Num_Click;
            btn_Num7.Click += Btn_Num_Click;
            btn_Num8.Click += Btn_Num_Click;
            btn_Num9.Click += Btn_Num_Click;
            btn_Num0.Click += Btn_Num_Click;

            btn_Repeat.Click += Btn_Repeat_Click;
        }

        private void Btn_Repeat_Click(object sender, EventArgs e)
        {
            switch ((Enums.States)currentState)
            {
                case Enums.States.EnterJaratszam:
                    {
                        this.currentState = (int)Enums.States.Startup;
                        break;
                    }
            }
        }

        private void Btn_Num_Click(object sender, EventArgs e)
        {
            string buttonText = ((VultronButton)sender).Text;

            switch((Enums.States)currentState)
            {
                case Enums.States.EnterJaratszam:
                    {
                        if(vultronLCD1.Lines[1] == "_")
                        {
                            currentJaratszam = Convert.ToInt32(vultronLCD1.Lines[1].Remove(0) + buttonText);
                            vultronLCD1.Lines = new string[] { "Kérem a járatszámot!", vultronLCD1.Lines[1].Remove(0) + buttonText };
                        }
                        else
                        {
                            currentJaratszam = Convert.ToInt32(vultronLCD1.Lines[1] + buttonText);
                            vultronLCD1.Lines = new string[] { "Kérem a járatszámot!", vultronLCD1.Lines[1] + buttonText };
                        }
                        break;
                    }
                case Enums.States.EnterKocsiszam:
                    {
                        if (vultronLCD1.Lines[1] == "_")
                        {
                            currentCarNumber = Convert.ToInt32(vultronLCD1.Lines[1].Remove(0) + buttonText);
                            vultronLCD1.Lines = new string[] { "Kérem a kocsiszámot!", vultronLCD1.Lines[1].Remove(0) + buttonText };
                        }
                        else
                        {
                            currentCarNumber = Convert.ToInt32(vultronLCD1.Lines[1] + buttonText);
                            vultronLCD1.Lines = new string[] { "Kérem a kocsiszámot!", vultronLCD1.Lines[1] + buttonText };
                        }
                        break;
                    }
            }
        }

        public void OnStateChange(int newState)
        {
            switch((Enums.States)this.currentState)
            {
                case Enums.States.Startup:
                    {
                        vultronLCD1.Lines = new string[] { "Vultron Fedélzeti", "Vezérlő v2.0" };
                        AlignTextCenter();
                        timer1.Start();
                        break;
                    }
                case Enums.States.CheckDisplays:
                    {
                        vultronLCD1.Lines = new string[] { "BT: 01+ BT: 02-" };
                        timer1.Start();
                        break;
                    }
                case Enums.States.ChooseMode:
                    {
                        vultronLCD1.Lines = new string[] { "ENTER: menet", "CLEAR: szervíz" };
                        break;
                    }
                case Enums.States.EnterJaratszam:
                    {
                        vultronLCD1.Lines = new string[] { "Kérem a járatszámot!", "_" };
                        break;
                    }
                case Enums.States.EnterKocsiszam:
                    {
                        vultronLCD1.Lines = new string[] { "Kérem a kocsiszámot!", "_" };
                        break;
                    }
                case Enums.States.ChooseFromJaratok:
                    {
                        var vegallomas = (from x in context.Trains
                                          where x.trainnumber == currentJaratszam
                                          select x).FirstOrDefault().endstation;
                        vultronLCD1.Lines = new string[] { "Válasszon járatot!", currentJaratszam.ToString() + " - " + vegallomas };
                        break;
                    }
                case Enums.States.ChooseMegallo:
                    {
                        var elsomegallo = (from x in context.Stations
                                        where x.stoppingtrainnum == currentJaratszam
                                        select x).FirstOrDefault().stationname;
                        vultronLCD1.Lines = new string[] { "Válasszon megállót!", elsomegallo };
                        break;
                    }
                case Enums.States.BaseScreen:
                    {
                        vultronLCD1.Lines = new string[] { this.selectedVonat.trainnumber.ToString() + " " + this.selectedVonat.traintype, this.selectedVonat.endstation, this.selectedStations[megalloIndex].stationname, this.currentCarNumber == -1 ? "" : "Kocsiszám: " + this.currentCarNumber.ToString() };
                        led.InitKijelzo();
                        AlignTextCenter();
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch((Enums.States)this.currentState)
            {
                case Enums.States.Startup:
                    {
                        counter++;
                        if (counter == 3)
                        {
                            this.currentState = (int)Enums.States.ChooseMode;
                            this.counter = 0;
                            timer1.Stop();
                        }
                        break;
                    }
                case Enums.States.CheckDisplays:
                    {
                        counter++;
                        if (counter == 4)
                        {
                            this.currentState = (int)Enums.States.EnterJaratszam;
                            this.counter = 0;
                            timer1.Stop();
                        }
                        break;
                    }
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            switch ((Enums.States)this.currentState)
            {
                case Enums.States.ChooseMode:
                    {
                        this.currentState = (int)Enums.States.CheckDisplays;
                        break;
                    }
                case Enums.States.EnterJaratszam:
                    {

                        var vonat = from x in context.Trains
                                    where x.trainnumber == currentJaratszam
                                    select x;

                        if(vonat.Count() > 0)
                        {
                            this.selectedVonat = vonat.FirstOrDefault();
                            this.currentState = (int)Enums.States.EnterKocsiszam;
                        }
                        else
                        {
                            this.currentState = (int)Enums.States.EnterJaratszam;
                        }
                        break;
                    }
                case Enums.States.EnterKocsiszam:
                    {
                        this.currentState = (int)Enums.States.ChooseFromJaratok;
                        break;
                    }
                case Enums.States.ChooseFromJaratok:
                    {
                        this.currentState = (int)Enums.States.ChooseMegallo;
                        break;
                    }
                case Enums.States.ChooseMegallo:
                    {
                        var megallok = from x in context.Stations
                                       where x.stoppingtrainnum == currentJaratszam
                                       select x;

                        var megalloLista = megallok.ToArray();

                        this.selectedStations = megalloLista;
                        this.currentState = (int)Enums.States.BaseScreen;
                        break;
                    }
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            switch((Enums.States)currentState)
            {
                case Enums.States.ChooseMegallo:
                    {
                        var megallok = from x in context.Stations
                                       where x.stoppingtrainnum == currentJaratszam
                                       select x;

                        var megalloLista = megallok.ToArray();

                        if(megalloIndex != megalloLista.Length - 1)
                        {
                            megalloIndex++;
                        }
                        updateLCD();
                        break;
                    }
                case Enums.States.BaseScreen:
                    {
                        if(megalloIndex != selectedStations.Length - 1)
                        {
                            megalloIndex++;
                        }
                        updateLCD();
                        break;
                    }
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            switch ((Enums.States)currentState)
            {
                case Enums.States.ChooseMegallo:
                    {
                        var megallok = from x in context.Stations
                                       where x.stoppingtrainnum == currentJaratszam
                                       select x;

                        var megalloLista = megallok.ToArray();

                        if (megalloIndex != 0)
                        {
                            megalloIndex--;
                        }
                        updateLCD();
                        break;
                    }
                case Enums.States.BaseScreen:
                    {
                        if (megalloIndex != 0)
                        {
                            megalloIndex--;
                        }
                        updateLCD();
                        break;
                    }
            }
        }

        private void updateLCD()
        {
            switch ((Enums.States)currentState)
            {
                case Enums.States.ChooseMegallo:
                    {
                        var megallok = from x in context.Stations
                                       where x.stoppingtrainnum == currentJaratszam
                                       select x;

                        var megalloLista = megallok.ToArray();

                        vultronLCD1.Lines = new string[] { "Válasszon megállót!", megalloLista[megalloIndex].stationname };
                        break;
                    }
                case Enums.States.BaseScreen:
                    {
                        vultronLCD1.Lines = new string[] { this.selectedVonat.trainnumber.ToString() + " " + this.selectedVonat.traintype, this.selectedVonat.endstation, this.selectedStations[megalloIndex].stationname, this.currentCarNumber == -1 ? "" : "Kocsiszám: " + this.currentCarNumber.ToString() };
                        AlignTextCenter();
                        break;
                    }
            }
        }

        private void AlignTextCenter()
        {
            vultronLCD1.SelectAll();
            vultronLCD1.SelectionAlignment = HorizontalAlignment.Center;
            vultronLCD1.DeselectAll();
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            if(this.currentState == (int)Enums.States.BaseScreen)
            {
                CreateExcel();
            }
        }

        void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch(Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        void CreateTable()
        {
            xlSheet.Cells[1, 1] = "Vonat menetrend exportja";
            xlSheet.Cells[2, 1] = "Vonat száma:";
            xlSheet.Cells[2, 2] = this.selectedVonat.trainnumber;
            xlSheet.Cells[3, 1] = "Vonat neme:";
            xlSheet.Cells[3, 2] = this.selectedVonat.traintype;
            xlSheet.Cells[4, 1] = "Vonat végállomása:";
            xlSheet.Cells[4, 2] = this.selectedVonat.endstation;
            xlSheet.Cells[5, 1] = "Vonat megállási helyei:";

            int rowCount = 6;
            foreach(Stations s in this.selectedStations)
            {
                xlSheet.Cells[rowCount, 1] = s.stationname;
                rowCount++;
            }

            Excel.Range dataRange = xlSheet.get_Range(GetCell(1, 2), GetCell(5, 2));
            dataRange.Font.Bold = true;
            dataRange.EntireColumn.AutoFit();
            dataRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Range labelRange = xlSheet.get_Range(GetCell(2, 1), GetCell(5, 1));
            labelRange.Font.Underline = true;
            labelRange.EntireColumn.AutoFit();

            Excel.Range fullRange = xlSheet.get_Range(GetCell(2, 1), GetCell(4, 2));
            fullRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            xlSheet.Cells[1, 1].Font.Size = 24;
            xlSheet.Cells[1, 1].Font.Bold = true;
            xlSheet.Cells[6, 1].Font.Italic = true;
            xlSheet.Cells[6 + selectedStations.Length - 1, 1].Font.Italic = true;
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}
