using Assignment3;

Console.WriteLine("Choose assignment to run (1, 2, 3, 4):");
var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Question1.Main(args);
        break;
    case "2":
        Question2.Main(args);
        break;
    case "3":
        Question3.Main(args);
        break;
    case "4":
        Question4.Main(args);
        break;
    
    default:
        Console.WriteLine("Invalid choice.");
        break;
}