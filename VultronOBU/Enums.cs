using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VultronOBU
{
    class Enums
    {
        public enum States
        {
            Startup,    // 0
            ChooseMode,
            CheckDisplays,
            EnterJaratszam,
            ChooseFromJaratok,
            ChooseMegallo,
            BaseScreen,
            Error,
            EnterKocsiszam
        }

        public enum LEDStates
        {
            Welcome,
            RouteInfo,
            NextStop,
            DateTime,
            Goodbye
        }
    }
}
