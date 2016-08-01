namespace Project_M_CSharp
{
    class Spieler : Player
    {
        public Spieler(string spieler_Name, Feld.Content sp_Farbe, params Startfeld[] startfeld_Array) : base(startfeld_Array)
        {
            name = spieler_Name;
            spielerFarbe = sp_Farbe;
        }
    }
}
