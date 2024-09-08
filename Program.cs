using System;

do {
    Console.WriteLine(
        "Welcome to the Champions League Draw! " +
        "\n_____________________________________" +
        "\nWhat would you like to do? " +
        "\nView pots = 1" +
        "\nDraw matches = 2" +
        "\nView matches = 3");

    string input  = Console.ReadLine();

    switch(input)
    {
        case "1":
            viewPots();
            break;
        case "2":
            drawMatches();
            break;
        case "3":
            viewMatches();
            break;
        default:
            Console.WriteLine("Please enter a number coreseponding to an option shown.");
            break;
    }
} while (true); 

static void viewPots() {
    //pots
    string[] pot1 = { "Real Madrid", "Manchester City", "Bayern Munchen", "PSG", "Liverpool", "Inter", "Dortmund", "Leipzig", "Barcelona" };
    string[] pot2 = { "Leverkusen", "Atletico Madrid", "Atalanta", "Juventus", "Benfica", "Arsenal", "Brugge", "Shakhtar", "AC Milan" };
    string[] pot3 = { "Celtic <3", "Feyernoord", "Sporting CP", "PSV", "Dynamo Zagreb", "Salzburg", "Lille", "Red Star Belgrade", "Young Boys" };
    string[] pot4 = { "Bratislava", "Monaco", "Sparta Prague", "Aston Villa", "Bologna", "Girona", "Stuttgart", "Strum Graz", "Brest" };
    
    Console.WriteLine("Pot 1 Teams: " + string.Join(", ", pot1));
    Console.WriteLine("Pot 2 Teams: " + string.Join(", ", pot2));
    Console.WriteLine("Pot 3 Teams: " + string.Join(", ", pot3));
    Console.WriteLine("Pot 4 Teams: " + string.Join(", ", pot4));
    Console.WriteLine();
}

static void drawMatches()
{
    Console.WriteLine(
        "We will begin by drawing all of the matches for the teams in pot 1." +
        "\nare you ready to begin?");
    string input = Console.ReadLine().ToLower();

    if (input == "yes")
    {
        //put pots in method
        string[] pot1 = { "Real Madrid", "Manchester City", "Bayern Munchen", "PSG", "Liverpool", "Inter", "Dortmund", "Leipzig", "Barcelona" };
        string[] pot2 = { "Leverkusen", "Atletico Madrid", "Atalanta", "Juventus", "Benfica", "Arsenal", "Brugge", "Shakhtar", "AC Milan" };
        string[] pot3 = { "Celtic <3", "Feyernoord", "Sporting CP", "PSV", "Dynamo Zagreb", "Salzburg", "Lille", "Red Star Belgrade", "Young Boys" };
        string[] pot4 = { "Bratislava", "Monaco", "Sparta Prague", "Aston Villa", "Bologna", "Girona", "Stuttgart", "Strum Graz", "Brest" };

        //logic
        //if statement to iterate through and pick the teams.
        //store matches in arrays 
        //pass arrays to viewMatches()

        }
    else //recursion
    {
        Console.WriteLine("Type 'yes' when you're ready. \n");
        drawMatches();
    }
}

static void viewMatches()
{
    //check the matches have been drawn. 
    //display matches
}