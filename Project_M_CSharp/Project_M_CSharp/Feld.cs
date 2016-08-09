using System.Windows.Forms;

namespace Project_M_CSharp
{
    class Feld : Button
    {
        public Feld[] Nachbarn;
        public Content Inhalt;
        public int EntfernungZumZiel;
        
        public void setAttributes(Content Inhalt, int Distanz)
        {
            this.Inhalt = Inhalt;
            EntfernungZumZiel = Distanz;
        }

        public void setNeighbors (params Feld[] Felder)
        {
            Nachbarn = Felder;
        }

        public enum Content{ 
            RED = 1, GREEN, YELLOW, BLUE, BLOCK, BLACK, GOAL
        };
    }
}
