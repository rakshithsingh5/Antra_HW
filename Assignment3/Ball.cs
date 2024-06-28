namespace Assignment3;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            size = value;
        }
    }

    public Color Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }

    public int ThrowCount
    {
        get
        {
            return throwCount;
        }
    }

    public void Pop()
    {
        size = 0;
    }

    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }
}