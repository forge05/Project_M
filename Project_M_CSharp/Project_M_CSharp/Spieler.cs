namespace Project_M_CSharp
{
    class Spieler : Player
    {
        public Spieler(string SpielerName, Feld.Content SpielerFarbe, params Startfeld[] Startfelder) : base(Startfelder)
        {
            PlayerName = SpielerName;
            PlayerFarbe = SpielerFarbe;
        }
    }
}
