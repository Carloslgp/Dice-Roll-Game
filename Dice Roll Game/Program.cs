using Dice_Roll_Game.Game;

var dice = new Dice(6);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);




Console.ReadKey();


