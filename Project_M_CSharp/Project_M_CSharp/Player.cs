using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_M_CSharp
{
    class Player
    {
        public string PlayerName;
        public Feld.Content PlayerFarbe;
        public Startfeld[] StartfeldArray;

        public Player(Startfeld[] Startfelder)  //für KI wäre ein Array vom Typ Feld sinnvoller
        {
            StartfeldArray = Startfelder;
        }
    }
}
