using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_M_CSharp
{
    class CPU : Player
    {
        public CPU(string CPU_Name, Feld.Content CPU_Farbe, params Startfeld[] startfelder_Array) : base(startfelder_Array)
        {
            PlayerName = CPU_Name;
            PlayerFarbe = CPU_Farbe;
        }
    }
}
