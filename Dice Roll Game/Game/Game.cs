using Dice_Roll_Game.UserCommunication;

namespace Dice_Roll_Game.Game
{
    class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            int diceRollResult = _dice.GetNumber();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

            int triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number.");
                --triesLeft;
            }
            return GameResult.Loss;


        }
        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory ? "You Win!!!" : "You lose :(";
            Console.WriteLine(message);
        }

    }

}
