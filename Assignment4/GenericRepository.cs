namespace Assignment4;

public class GenericRepository<T> : IRespository<T> where T: Entity
{
    private readonly List<T> _context;

    public GenericRepository()
    {
        _context = new List<T>();
    }

    // Adds an item to the repository
    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        _context.Add(item);
    }

    // Removes an item from the repository
    public void Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        _context.Remove(item);
    }

    // Saves changes (for in-memory data, this might not be needed, but it's here for completeness)
    public void Save()
    {
        // In a real implementation, this would persist changes to the database
    }

    // Returns all items in the repository
    public IEnumerable<T> GetAll()
    {
        return _context;
    }

    // Returns an item by its Id
    public T GetById(int id)
    {
        return _context.FirstOrDefault(e => e.Id == id);
    }
}