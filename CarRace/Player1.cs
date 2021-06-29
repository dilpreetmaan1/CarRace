using System.Windows.Forms;

namespace CarRace
{
    using System;

    public class Player1 : Racer
    {
        public Player1(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setRacerName()
        {
            Name = "Player1";
        }
    }
}