using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_M_CSharp
{
    class CPU : Player
    {
        public CPU(string CPU_Name, Feld.Content CPU_Farbe)
        {
            name = CPU_Name;
            spielerFarbe = CPU_Farbe;
        }
    }
}
