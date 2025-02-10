namespace Dice_Roll_Game.Game
{
    public class Dice
    {
        private int RandomNumber;
        private readonly int SidesCount;

        public Dice(int sidesCount)
        {
            SidesCount = sidesCount;
            RandomNumber = Roll();
        }

        public int GetNumber() => RandomNumber;

        public int Roll()
        {
            Random rdn = new Random();
            return rdn.Next(1, SidesCount + 1);
        }

    }

}
