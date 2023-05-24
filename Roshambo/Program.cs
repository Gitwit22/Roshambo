using Roshambo;

Console.WriteLine("Enter your name:");
string playerName = Console.ReadLine();
HumanPlayer humanPlayer = new HumanPlayer(playerName);

Console.WriteLine("Select your opponent:");
Console.WriteLine("1. Rock Player");
Console.WriteLine("2. Random Player");
string opponentChoice = Console.ReadLine();

Player opponent;
switch (opponentChoice)
{
    case "1":
        opponent = new RockPlayer();
        break;
    case "2":
        opponent = new RandomPlayer();
        break;
    default:
        Console.WriteLine("Invalid choice! Exiting the game.");
        return;
}

Roshambo humanPlayerValue = humanPlayer.GenerateRoshambo();
Roshambo opponentValue = opponent.GenerateRoshambo();

Console.WriteLine($"{humanPlayer.Name} chose {humanPlayerValue}");
Console.WriteLine($"{opponent.Name} chose {opponentValue}");
Console.WriteLine();


if (humanPlayerValue == opponentValue)
{
    Console.WriteLine("It's a tie!");
}else if
    (humanPlayerValue == Roshambo.Rock && opponentValue == Roshambo.Scissors ||
    humanPlayerValue == Roshambo.Paper && opponentValue == Roshambo.Rock ||
    humanPlayerValue == Roshambo.Scissors && opponentValue == Roshambo.Paper)
    { 
    Console.WriteLine($"{humanPlayer.Name} wins!");
}
else
{
    Console.WriteLine($"{opponent.Name} wins!");
}