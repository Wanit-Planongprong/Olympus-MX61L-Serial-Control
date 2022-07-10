using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympus_MX61_MX61L_Serial_comm
{
    public static class MX61_MX61L_Command
       
    {
        /// <summary>
        /// Login
        /// Command: 1LOG IN, Type: Request
        /// Local to remote mode switching.
        /// </summary>
        public static string Login
        {
            get
            {
                return "1LOG IN";
            }
        }
        /// <summary>
        /// Logout
        /// Command: 1LOG OUT, Type: Request
        /// Remote to local mode swithing
        /// </summary>
        public static string Logout
        {
            get
            {
                return "1LOG OUT";
            }
        }
        public static string LoginState 
        {
            get
            {
                return "1LOG?";
            }
        }
 
        public static string Objective(int value) 
        {
                return $"1OB {value}";
        }
        public static string ObjectivePos
        {
            get
            {
                return "1OB?";
            }
        }
        public static string Obj_AS(int value)
        {
                return $"1OBA {value}";
        }
        public static string Cube_Status
        {
            get
            {
                return "1CUBE?";
            }
        }
        public static string Unit_presence
        {
            get
            {
                return "1UNIT?";
            }
        }
        public static string Gare_Prevent_on
        {
            get
            {
                return "1FPV ON";
            }
        }
        public static string Gare_Prevent_off
        {
            get
            {
                return "1FPV OFF";
            }
        }
        public static string Gare_Prevent_State
        {
            get
            {
                return "1FPV?";
            }
        }
    }

   
}
