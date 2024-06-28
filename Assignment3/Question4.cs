namespace Assignment3;

public class Question4
{
    public static void Main(string[] args)
    {
        Color redColor = new Color(255, 0, 0);
        Color greenColor = new Color(0, 255, 0);
        Color blueColor = new Color(0, 0, 255);

        Ball redBall = new Ball(10, redColor);
        Ball greenBall = new Ball(20, greenColor);
        Ball blueBall = new Ball(30, blueColor);

        redBall.Throw();
        redBall.Throw();
        greenBall.Throw();
        blueBall.Throw();
        blueBall.Throw();
        blueBall.Throw();
        greenBall.Pop();
        greenBall.Throw();

        Console.WriteLine($"Red ball thrown {redBall.ThrowCount} times.");
        Console.WriteLine($"Green ball thrown {greenBall.ThrowCount} times.");
        Console.WriteLine($"Blue ball thrown {blueBall.ThrowCount} times.");
    }
}