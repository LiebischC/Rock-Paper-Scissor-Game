//  Random random = new Random();
//             bool playAgain = true;
//             String player;
//             String computer;
//             String answer;

//             while (playAgain)
//             {
//                 player = "";
//                 computer = "";
//                 answer = "";

//                 while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
//                     Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
//                     player = Console.ReadLine() ?? "";
//                     player = player.ToUpper();
//                 }

                
//                 switch (random.Next(1, 4))
//                 {
//                     case 1:
//                         computer = "ROCK";
//                         break;
//                     case 2:
//                         computer = "PAPER";
//                         break;
//                     case 3:
//                         computer = "SCISSORS";
//                         break;
//                 }

//                 Console.WriteLine("Player: " + player);
//                 Console.WriteLine("Computer: " + computer);

//                 switch (player)
//                 {
//                     case "ROCK":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         break;
//                     case "PAPER":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         break;
//                     case "SCISSORS":
//                         if (computer == "ROCK")
//                         {
//                             Console.WriteLine("You lose!");
//                         }
//                         else if (computer == "PAPER")
//                         {
//                             Console.WriteLine("You win!");
//                         }
//                         else
//                         {
//                             Console.WriteLine("It's a draw!");
//                         }
//                         break;
//                 }

//                 Console.Write("Would you like to play again (Y/N): ");
//                 answer = Console.ReadLine() ?? "";
//                 answer = answer.ToUpper();

//                 if (answer == "Y")
//                 {
//                     playAgain = true;
//                 }
//                 else
//                 {
//                     playAgain = false;
//                 }
                
//             }

//             Console.WriteLine("Thanks for playing!");

//             Console.ReadKey();
        
    
Random random = new Random();
bool playAgain = true;
string player;
string computer;
string answer;
Console.WriteLine("Welcome to Rock, Paper, Scissors!");
while (playAgain)
{
    player = "";
    computer = "";
    answer = "";

    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("Enter R for ROCK, P for PAPER, or S for SCISSORS: ");
        string input = Console.ReadLine() ?? "";
        input = input.ToUpper();

        switch (input)
        {
            case "R":
                player = "ROCK";
                break;
            case "P":
                player = "PAPER";
                break;
            case "S":
                player = "SCISSORS";
                break;
            default:
                player = ""; // invalid input, loop continues
                break;
        }
    }

    switch (random.Next(1, 4))
    {
        case 1: computer = "ROCK"; break;
        case 2: computer = "PAPER"; break;
        case 3: computer = "SCISSORS"; break;
    }

    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK") Console.WriteLine("It's a draw!");
            else if (computer == "PAPER") Console.WriteLine("You lose!");
            else Console.WriteLine("You win!");
            break;
        case "PAPER":
            if (computer == "ROCK") Console.WriteLine("You win!");
            else if (computer == "PAPER") Console.WriteLine("It's a draw!");
            else Console.WriteLine("You lose!");
            break;
        case "SCISSORS":
            if (computer == "ROCK") Console.WriteLine("You lose!");
            else if (computer == "PAPER") Console.WriteLine("You win!");
            else Console.WriteLine("It's a draw!");
            break;
    }

    Console.Write("Would you like to play again (Y/N): ");
    answer = Console.ReadLine() ?? "";
    answer = answer.ToUpper();

    playAgain = (answer == "Y");
}

Console.WriteLine("Thanks for playing!");
Console.ReadKey();