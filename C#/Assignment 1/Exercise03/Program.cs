// See https://aka.ms/new-console-template for more information

/* 1. FizzBuzz */
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

int max = 500; for (byte i = 0; i < max; i++) { Console.WriteLine(i); }
// infinity loop 




/* 2. print -a-Pyramid*/
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5 - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}


/* 3.Random number and guess*/
Random n = new Random();
int rnum = n.Next(0, 4);
Console.WriteLine("guess number between 1 and 3");
int gnum = Convert.ToInt32(Console.ReadLine());

if (Enumerable.Range(1, 3).Contains(gnum))
{
    if (gnum == rnum)
    {
        Console.WriteLine("correct");
    }
    if (gnum > rnum)
    {
        Console.WriteLine("high");
    }
    if (gnum < rnum)
    {
        Console.WriteLine("low");
    }
}
else
{
    Console.WriteLine("out of range");
}


/*4.Write a simple program that defines a variable representing a birth date and calculates */

DateTime Currentt = DateTime.Today;

Console.WriteLine("Enter the month: ");
int bMonth = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the day: ");
int bDay = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the year: ");
int bYear = int.Parse(Console.ReadLine());

DateTime Born = new DateTime(bYear, bMonth, bDay);

TimeSpan diff1 = Currentt.Subtract(Born);
Console.WriteLine(diff1);


/*5.Write a program that greets the user using the appropriate greeting for the time of day. */

DateTime Current = DateTime.Now;
int cHour = Current.Hour;
int Morning = 6;
int Afternoon = 12;
int Evening = 18;
int Night = 22;

if (Morning <= cHour && cHour < Afternoon)
{
    Console.WriteLine("Good Morning");
};

if (Afternoon <= cHour && cHour < Evening)
{
    Console.WriteLine("Good Afternoon!");
};

if (Evening <= cHour && cHour < Night)
{
    Console.WriteLine("Good Evening!");
};

if (Night <= cHour || cHour < Morning)
{
    Console.WriteLine("Good Night!");
};

/*6.Write a program that prints the result of counting up to 24 using four different increments. */
for (int i = 1; i <= 4; i += 1)
{
    for (int j = 0; j <= 24; j += i)
    {
        Console.Write($"{j},");
    }

    Console.WriteLine();
}