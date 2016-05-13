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
        public Feld[] nachbarn;
        public Content content;
        public int Entfernung_zum_Ziel;
        public bool schonGeruecktWorden;
        //Button b = new Button();
        public Feld(Content c, int distanz) : base()
        {
            content = c;
            Entfernung_zum_Ziel = distanz;
            //Entfern_zum_Ziel = (int)this.Tag;   //später noch anpassen und im Konstruktor eingeben ohne Tag-Feld
        }

        public void setNachbar (params Feld[] ButtonList)
        {
            nachbarn = ButtonList;
        }

        public enum Content { 
            RED,
            GREEN,
            YELLOW,
            BLUE,
            BLOCK,
            EMPTY,
            GOAL
        };
    }
}
