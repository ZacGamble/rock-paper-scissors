string computerChoice = "";
int terminator = 0;

Random random = new Random();

while (terminator == 0)
{
    Console.WriteLine("Select (r) for rock, (p) for paper, and (s) for scissors, and (q) to quit");
    var userInput = Console.ReadKey().KeyChar;

    switch (random.Next(3))
    {
        case 0:
            computerChoice = "rock";
            break;
        case 1:
            computerChoice = "paper";
            break;
        case 2:
            computerChoice = "scissors";
            break;
        default:
            Console.WriteLine("\nThat is an invalid input.");
            break;
    }
    //quit logic
    if (userInput == 'q')
    {
        Console.WriteLine("\nGoodbye!");
        terminator++;
    }

    //rock input logic
    if (userInput == 'r' && computerChoice == "rock")
    {
        Console.WriteLine("\nIts a tie!");
    }
    if (userInput == 'r' && computerChoice == "scissors")
    {
        Console.WriteLine("\nYou win!");
    }
    if (userInput == 'r' && computerChoice == "paper")
    {
        Console.WriteLine("\nYou lose!");
    }
    //paper logic
    if (userInput == 'p' && computerChoice == "paper")
    {
        Console.WriteLine("\nIts a tie!");
    }
    if (userInput == 'p' && computerChoice == "scissors")
    {
        Console.WriteLine("\nYou lose!");
    }
    if (userInput == 'p' && computerChoice == "rock")
    {
        Console.WriteLine("\nYou win!");
    }
    //scissors logic
    if (userInput == 's' && computerChoice == "scissors")
    {
        Console.WriteLine("\nIts a tie!");
    }
    if (userInput == 's' && computerChoice == "rock")
    {
        Console.WriteLine("\nYou lose!");
    }
    if (userInput == 's' && computerChoice == "paper")
    {
        Console.WriteLine("\nYou win!");
    }
}