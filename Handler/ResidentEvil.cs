using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static Resident_Evil_2_RPC.RPC;
using System.Threading.Tasks;

namespace Resident_Evil_2_RPC.Handler
{
    public static class ResidentEvil
    {
        public static void Check()
        {
            if (Process.GetProcessesByName("re2").Length > 0)
            {
                isrunning = true;
            }
            if (Process.GetProcessesByName("re2").Length > 1 )
            {
                isrunning = false;
            }
        }
    }
}
