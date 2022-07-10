using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus_MX61_MX61L_Serial_comm
{
    public static class HardwareInteface
    {
        public static string Lighting(int value)
        {
                return $"LIGHT {value}";
        }

        public static string getLighValue
        {
            get
            {
                return "LIGHT";
            }
        }
        public static string IDI(int value)
        {
            return $"IDI {value}";
        }

        public static string ODION(int value)
        {
            return $"ODON {value}";
        }

        public static string ODIOFF(int value)
        {
            return $"ODOFF {value}";
        }
        public static string IDI_State(int value)
        {
            return $"IDI? {value}";
        }
    }
}
