using System;

Console.WriteLine(@"   ____  _    _ _____ ______");
Console.WriteLine(@"  / __ \| |  | |_   _|___  /");
Console.WriteLine(@" | |  | | |  | | | |    / / ");
Console.WriteLine(@" | |  | | |  | | | |   / /  ");
Console.WriteLine(@" | |__| | |__| |_| |_ / /__ ");
Console.WriteLine(@"  \___\_\\____/|_____/_____|");

Console.WriteLine();

Console.WriteLine("Welcome to the Quiz");
Console.WriteLine("Press 'Enter' to Continue");

Console.ReadLine();
Console.Clear();

int points = 0;

string answer1 = "";

while (answer1 != "a" && answer1 != "b" && answer1 != "c")
{
    Console.WriteLine("Question 1");
    Console.WriteLine();
    Console.WriteLine("Which Aston Martin was used in the latest Bond Movie?");
    Console.WriteLine("a - DB11  b - DB5  c - DB7");

    answer1 = Console.ReadLine().ToLower();
    Console.Clear();
}

if (answer1 == "a")
{
    Console.WriteLine("You Picked the wrong answer, you dont get a score.");
    Console.WriteLine("Press 'Enter' to Continue");
}
else if (answer1 == "b")
{
    Console.WriteLine("You choosed Aston Martin DB5, you answered right you get a score.");
    Console.WriteLine("Press 'Enter' to Continue");

    points = points + 1;

}
else if (answer1 == "c")
{
    Console.WriteLine("You Picked the wrong answer, you dont get a score.");
    Console.WriteLine("Press 'Enter' to Continue");
}

Console.ReadLine();
Console.Clear();


string answer2 = "";

while (answer2 != "a" && answer2 != "b" && answer2 != "c")
{
    Console.WriteLine("Question 2");
    Console.WriteLine();
    Console.WriteLine("What is the name of the upcoming James Bond movie?");
    Console.WriteLine("a - Casino Royal  b - Skyfall  c - No Time To Die");


    answer2 = Console.ReadLine().ToLower();
    Console.Clear();
}

if (answer2 == "a")
{
    Console.WriteLine("You Picked the wrong answer, you dont get a score.");
    Console.WriteLine("Press 'Enter' to Continue");
}
else if (answer2 == "b")
{
    Console.WriteLine("You Picked the wrong answer, you dont get a score.");
    Console.WriteLine("Press 'Enter' to Continue");
}
else if (answer2 == "c")
{
    Console.WriteLine("You choosed No Time To Die, you answered right you get a score.");
    Console.WriteLine("Press 'Enter' to Continue");

    points = points + 1;
}

Console.ReadLine();
Console.Clear();


string answer3 = "";

while (answer3 != "a" && answer3 != "b" && answer3 != "c")
{
    Console.WriteLine("Question 3");
    Console.WriteLine();
    Console.WriteLine("What year did the James Bond franchies begin?");
    Console.WriteLine("a - 1962  b - 1983  c - 2002");


    answer3 = Console.ReadLine().ToLower();
    Console.Clear();
}

if (answer3 == "a")
{
    Console.WriteLine("You choosed 1962, you answered right you get a score.");
    Console.WriteLine("Press 'Enter' to Continue");

    points = points + 1;
}
else if (answer3 == "b")
{
    Console.WriteLine("You Picked the wrong answer, you dont get a score.");
    Console.WriteLine("Press 'Enter' to Continue");
}
else if (answer3 == "c")
{
    Console.WriteLine("You Picked the wrong answer, you dont get a score.");
    Console.WriteLine("Press 'Enter' to Continue");
}

Console.ReadLine();
Console.Clear();


Console.WriteLine($"Your Score is: {points}");
Console.WriteLine("Press 'Enter' to Exit");

Console.ReadLine();