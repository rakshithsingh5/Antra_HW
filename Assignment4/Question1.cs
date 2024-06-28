namespace Assignment4;

public class MyStack<T>
{
    private List<T> elements;

    public MyStack()
    {
        elements = new List<T>();
    }

    // Returns the number of elements in the stack
    public int Count()
    {
        return elements.Count;
    }

    // Removes and returns the top element of the stack
    public T Pop()
    {
        if (elements.Count == 0)
        {
            Console.WriteLine("Stack is empty.");
        }

        T topElement = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return topElement;
    }

    // Adds an element to the top of the stack
    public void Push(T item)
    {
        elements.Add(item);
    }
}