
string computerChoice = "";
int terminator = 0;

int GbelowC = 196 * 2;
int A = 220 * 2;
int Asharp = 233 * 2;
int B = 247 * 2;
int C = 262 * 2;
int Csharp = 277 * 2;
int D = 294 * 2;
int Dsharp = 311 * 2;
int E = 330 * 2;
int F = 349 * 2;
int Fsharp = 370 * 2;
int G = 392 * 2;
int Gsharp = 415 * 2;


string rock = @" 
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";
string paper = @"    
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)";
string scissors = @"    
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)";

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
            Console.WriteLine("\n\nThat is an invalid input.");
            break;
    }

    //quit logic
    if (userInput == 'q')
    {
        Console.WriteLine("\n\nGoodbye!");
        Console.Beep(Gsharp, 200);
        Console.Beep(GbelowC, 200);
        terminator++;
    }

    //rock input logic
    if (userInput == 'r' && computerChoice == "rock")
    {
        Console.Write($"\n\n{rock}");
        Console.Beep(F, 200);
        Console.Beep(E, 200);
        Thread.Sleep(500);
        Console.WriteLine("\n\nIts a tie!");
    }
    if (userInput == 'r' && computerChoice == "scissors")
    {
        Console.Write($"\n\n{scissors}");
        Console.Beep(C, 125);
        Console.Beep(D, 125);
        Console.Beep(E, 125);
        Console.Beep(G, 500);
        Thread.Sleep(500);
        Console.WriteLine("\n\nYou win!");
    }
    if (userInput == 'r' && computerChoice == "paper")
    {
        Console.Write($"\n\n{paper}");
        Console.Beep(F, 500);
        Console.Beep(E, 500);
        Console.Beep(GbelowC, 750);
        Thread.Sleep(500);
        Console.WriteLine("\n\nYou lose!");
    }

    //paper logic
    if (userInput == 'p' && computerChoice == "paper")
    {
        Console.Write($"\n\n{paper}");
        Console.Beep(F, 200);
        Console.Beep(E, 200);
        Thread.Sleep(500);
        Console.WriteLine("\n\nIts a tie!");
    }
    if (userInput == 'p' && computerChoice == "scissors")
    {
        Console.Write($"\n\n{scissors}");
        Console.Beep(F, 500);
        Console.Beep(E, 500);
        Console.Beep(GbelowC, 750);
        Thread.Sleep(500);
        Console.WriteLine("\n\nYou lose!");
    }
    if (userInput == 'p' && computerChoice == "rock")
    {
        Console.Write($"\n\n{rock}");
        Console.Beep(C, 125);
        Console.Beep(D, 125);
        Console.Beep(E, 125);
        Console.Beep(A, 500);
        Thread.Sleep(500);
        Console.WriteLine("\n\nYou win!");
    }

    //scissors logic
    if (userInput == 's' && computerChoice == "scissors")
    {
        Console.Write($"\n\n{scissors}");
        Console.Beep(F, 200);
        Console.Beep(E, 200);
        Thread.Sleep(500);
        Console.WriteLine("\n\nIts a tie!");
    }
    if (userInput == 's' && computerChoice == "rock")
    {
        Console.Write($"\n\n{rock}");
        Console.Beep(F, 500);
        Console.Beep(E, 500);
        Console.Beep(GbelowC, 750);
        Thread.Sleep(500);
        Console.WriteLine("\n\nYou lose!");
    }
    if (userInput == 's' && computerChoice == "paper")
    {
        Console.Write($"\n\n{paper}");
        Console.Beep(C, 125);
        Console.Beep(D, 125);
        Console.Beep(E, 125);
        Console.Beep(A, 500);
        Thread.Sleep(500);
        Console.WriteLine("\n\nYou win!");
    }

}
