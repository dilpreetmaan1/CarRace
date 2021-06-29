using System.Windows.Forms;

namespace CarRace
{
    public class Player3 : Racer
    {
        public Player3(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setRacerName()
        {
            Name = "Player3";
        }
    }
}