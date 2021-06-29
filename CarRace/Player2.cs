using System.Windows.Forms;


namespace CarRace
{
    using System;

    public class Player2 : Racer
    {
        public Player2(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setRacerName()
        {
            Name = "Player2";
        }
    }
}