using System.Windows.Forms;

namespace Project_M_CSharp
{
    class Feld : Button
    {
        public Feld[] Nachbarn;
        public Content Inhalt;
        public int EntfernungZumZiel;
        
        public void setAttributes(Content c, int distanz)
        {
            Inhalt = c;
            EntfernungZumZiel = distanz;
        }

        public void setNachbar (params Feld[] ButtonList)
        {
            Nachbarn = ButtonList;
        }

        public enum Content{ 
            RED = 1, GREEN, YELLOW, BLUE, BLOCK, BLACK, GOAL
        };
    }
}
