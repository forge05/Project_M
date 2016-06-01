using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_M_CSharp
{
    class Feld : Button
    {
        public Feld[] Nachbarn;
        public Content Inhalt;
        public int EntfernungZumZiel;
        //public bool SchonGeruecktWorden;

        //public Feld() : base()    //Default-Konstruktor implizit vorhanden (Button)
        //{

        //}

        //public Feld(Content c, int distanz) : base()  //können wir nicht verwenden, wegen des Designers
        //{
        //    content = c;
        //    Entfernung_zum_Ziel = distanz;
        //}

        public void setAttributes(Content c, int distanz)
        {
            Inhalt = c;
            EntfernungZumZiel = distanz;
        }

        public void setNachbar (params Feld[] ButtonList)
        {
            Nachbarn = ButtonList;
        }

        public enum Content { 
            RED,
            GREEN,
            YELLOW,
            BLUE,
            BLOCK,
            BLACK,
            GOAL
        };
    }
}
