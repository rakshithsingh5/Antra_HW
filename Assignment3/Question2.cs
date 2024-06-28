namespace Assignment3;

public class Question2
{
    public static void Main(string[] args)
    {
        // Loop through the first 10 numbers of the Fibonacci sequence
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
        }
    }

    static int Fibonacci(int n)
    {
        // Base case: the first and second numbers of the Fibonacci sequence are 1
        if (n == 1 || n == 2)
        {
            return 1;
        }
        // Recursive case: Fibonacci(n) = Fibonacci(n - 1) + Fibonacci(n - 2)
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    
    }
}