// See https://aka.ms/new-console-template for more information

using System.Text;


//Q1: Playing with Console App

    //  Here is an example of Hacker name Generator. We will first execute the code and then we will try to add mistakes.
    Console.WriteLine("Welcome to the Hacker Name Generator!");
    Console.Write("Enter your favorite color: ");
    string favoriteColor = Console.ReadLine();
    Console.Write("Enter your astrology sign: ");
    string astrologySign = Console.ReadLine();
    Console.Write("Enter your street address number: ");
    string streetAddressNumber = Console.ReadLine();
    string hackerName = favoriteColor + astrologySign + streetAddressNumber;
    Console.WriteLine("Your hacker name is " + hackerName);

    //Now we will intentionally add mistakes
    //Mistake1: Syntax error, ',' expected.
    int a=10

    //Mistake2: Identifier expected, Syntax error, ',' expected.
    int 1b = 'c';

    //Mistake3: Misspelled name error
    Console.Write("Enter your favorite color: ");
    string favoriteColor = Console.ReeadLine();

    //Mistake4: Already defined local variable, trying to assign a string into int
    Console.Write("Enter your favorite color: ");
    int favoriteColor = Console.ReadLine();

    //Mistake5: Unused variable
    int unusedVariable;
    
    
//Question: 
    //Part 1: 
    Console.WriteLine("Type      Bytes                 MinValue                          MaxValue");
    Console.WriteLine("----------------------------------------------------------------------------");

    Console.WriteLine("sbyte   {0,5}  {1,40}  {2,40}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
    Console.WriteLine("byte    {0,5}  {1,40}  {2,40}", sizeof(byte), byte.MinValue, byte.MaxValue);
    Console.WriteLine("short   {0,5}  {1,40}  {2,40}", sizeof(short), short.MinValue, short.MaxValue);
    Console.WriteLine("ushort  {0,5}  {1,40}  {2,40}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
    Console.WriteLine("int     {0,5}  {1,40}  {2,40}", sizeof(int), int.MinValue, int.MaxValue);
    Console.WriteLine("uint    {0,5}  {1,40}  {2,40}", sizeof(uint), uint.MinValue, uint.MaxValue);
    Console.WriteLine("long    {0,5}  {1,40}  {2,40}", sizeof(long), long.MinValue, long.MaxValue);
    Console.WriteLine("ulong   {0,5}  {1,40}  {2,40}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
    Console.WriteLine("float   {0,5}  {1,40}  {2,40}", sizeof(float), float.MinValue, float.MaxValue);
    Console.WriteLine("double  {0,5}  {1,40}  {2,40}", sizeof(double), double.MinValue, double.MaxValue);
    Console.WriteLine("decimal {0,5}  {1,40}  {2,40}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

    //Part2:
    Console.Write("\nEnter the number of centuries: ");
    int centuries = int.Parse(Console.ReadLine());

    int years = centuries * 100;
    int days = (int)(years * 365.2425);  // Using the average number of days in a year accounting for leap years
    long hours = days * 24;
    long minutes = hours * 60;
    long seconds = minutes * 60;
    long milliseconds = seconds * 1000;
    long microseconds = milliseconds * 1000;
    decimal nanoseconds = microseconds * 1000m;
    Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", 
        centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);


//Question 3: 
    //FizzBuzz game
     for (int i = 1; i <= 100; i++)
     {
         if (i % 3 == 0 && i % 5 == 0)
         {
             Console.WriteLine("fizzbuzz");
         }
         else if (i % 3 == 0)
         {
             Console.WriteLine("fizz");
         }
         else if (i % 5 == 0)
         {
             Console.WriteLine("buzz");
         }
         else
         {
             Console.WriteLine(i);
         }
     }

    //------Byte overflow in loop-------
         int max = 500;
         for (byte i = 0; i < max; i++)
         {
             Console.WriteLine(i);
         }
    // ->The `byte` data type can only store values between 0 and 255. As a result, when the loop variable `i` goes beyond 255, it will overflow, wrapping back to 0 and continuing to increment from there. This causes the loop to run indefinitely.
         //best case:
         int max = 500;
         for (byte i = 0; i < max; i++)
         {
             if (i == byte.MaxValue)
             {
                 Console.WriteLine("Warning: Byte overflow imminent!");
                 break;
             }
             Console.WriteLine(i);
         }
    //Guessing the game

                     Random random = new Random();
                     int correctNumber = random.Next(3) + 1;
                     Console.WriteLine("Guess a number between 1 and 3:");
                     int guessedNumber = int.Parse(Console.ReadLine());
                     if (guessedNumber < 1 || guessedNumber > 3)
                     {
                         Console.WriteLine("Your guess is out of the valid range.");
                     }
                     else if (guessedNumber < correctNumber)
                     {
                         Console.WriteLine("Your guess is too low.");
                     }
                     else if (guessedNumber > correctNumber)
                     {
                         Console.WriteLine("Your guess is too high.");
                     }
                     else
                     {
                         Console.WriteLine("Congratulations! You guessed the correct number.");
                     }

//Question6: Print-a-Pyramid
                    int a = 5;
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < a - i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                    
                        // Print stars
                        for (int k = 0; k < 2 * i + 1; k++)
                        {
                            Console.Write("*");
                        }
                    
                        Console.WriteLine();
                    }

//Question 4:
                    DateTime birthDate = new DateTime(1990, 1, 1); // Change this to the actual birth date
                    DateTime today = DateTime.Now;

                    int daysOld = (today - birthDate).Days;
                    Console.WriteLine($"You are {daysOld} days old.");

                    int daysToNextAnniversary = 10000 - (daysOld % 10000);
                    DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
                    Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversary.ToShortDateString()}.");

//Question 5: Use appropriate greeting for the time of the day.

                                DateTime currentTime = DateTime.Now;  //new DateTime(2024, 6, 22, 16, 0, 0);
                                
                                int hour = currentTime.Hour;
                                
                                if (hour >= 6 && hour < 12)
                                {
                                    Console.WriteLine("Good Morning");
                                }
                                if (hour >= 12 && hour < 18)
                                {
                                    Console.WriteLine("Good Afternoon");
                                }
                                if (hour >= 18 && hour < 22)
                                {
                                    Console.WriteLine("Good Evening");
                                }
                                if (hour >= 22 || hour < 6)
                                {
                                    Console.WriteLine("Good Night");
                                }
      
    
//Question6:   
                                for (int outer = 1; outer <= 4; outer++)
                                {
                                    for (int inner = 0; inner <= 24; inner += outer)
                                    {
                                        Console.Write(inner);
                                        if (inner + outer <= 24)
                                        {
                                            Console.Write(",");
                                        }
                                    }
                                    Console.WriteLine();
                                }                      