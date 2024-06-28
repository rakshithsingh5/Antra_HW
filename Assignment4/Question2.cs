namespace Assignment4;

public class MyList<T>
{
    private List<T> elements;

    public MyList()
    {
        elements = new List<T>();
    }

    // Adds an element to the end of the list
    public void Add(T element)
    {
        elements.Add(element);
    }
    
    // Returns the number of elements in the list
    public int Count
    {
        get { return elements.Count; }
    }


    // Removes the element at the specified index and returns it
    public T Remove(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        T removedElement = elements[index];
        elements.RemoveAt(index);
        return removedElement;
    }

    // Checks if the list contains the specified element
    public bool Contains(T element)
    {
        return elements.Contains(element);
    }

    // Clears all elements from the list
    public void Clear()
    {
        elements.Clear();
    }

    // Inserts an element at the specified index
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        elements.Insert(index, element);
    }

    // Deletes the element at the specified index
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        elements.RemoveAt(index);
    }

    // Finds and returns the element at the specified index
    public T Find(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException("Index out of range.");
        }
        return elements[index];
    }
}