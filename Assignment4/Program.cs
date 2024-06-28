using Assignment4;
using System;
using System.Collections.Generic;

Console.WriteLine("Choose Question answer to run (1, 2, 3, ):");
var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        RunQuestion1();
        break;
    case "2":
        RunQuestion2();
        break;
    case "3":
        RunQuestion3();
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

static void RunQuestion1()
{
    MyStack<int> intStack = new MyStack<int>();
    intStack.Push(1);
    intStack.Push(2);
    intStack.Push(3);
    Console.WriteLine("Count: " + intStack.Count());  // Output: 3
    Console.WriteLine("Pop: " + intStack.Pop());      // Output: 3
    Console.WriteLine("Count: " + intStack.Count());  // Output: 2

    MyStack<string> stringStack = new MyStack<string>();
    stringStack.Push("Hello");
    stringStack.Push("World");
    Console.WriteLine("Count: " + stringStack.Count());  // Output: 2
    Console.WriteLine("Pop: " + stringStack.Pop());      // Output: World
    Console.WriteLine("Count: " + stringStack.Count());  // Output: 1
}

static void RunQuestion2()
{
    MyList<int> list = new MyList<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);
    Console.WriteLine("Contains 2: " + list.Contains(2));  // Output: True
    Console.WriteLine("Element at index 1: " + list.Find(1));  // Output: 2
    list.InsertAt(4, 1);
    Console.WriteLine("Element at index 1 after insertion: " + list.Find(1));  // Output: 4
    list.DeleteAt(1);
    Console.WriteLine("Element at index 1 after deletion: " + list.Find(1));  // Output: 2
    list.Clear();
    Console.WriteLine("Count after clearing: " + list.Count);  // Output: 0
}

static void RunQuestion3()
{
    var repository = new GenericRepository<EntityExample>();
            
    var item1 = new EntityExample { Id = 1, Name = "Item 1" };
    var item2 = new EntityExample { Id = 2, Name = "Item 2" };

    repository.Add(item1);
    repository.Add(item2);

    Console.WriteLine("All items in repository:");
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
    }

    var itemById = repository.GetById(1);
    Console.WriteLine($"Item with Id 1: {itemById.Name}");

    repository.Remove(item1);
    repository.Save();

    Console.WriteLine("All items in repository after removal:");
    foreach (var item in repository.GetAll())
    {
        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
    }
}

public class EntityExample : Entity
{
    public string Name { get; set; }
}
