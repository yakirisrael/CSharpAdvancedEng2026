using System.Collections;

namespace Lesson04;

public class Inventory : IEnumerable
{
    private readonly int capacity;
    
    private Item[] items;

    public Inventory(int capacity)
    {
        this.capacity = capacity;
        items = new Item[capacity];
    }

    public int Capacity
    {
        get { return items.Length; }
    }

    public int Count
    {
        get
        {
            int count = 0;
            foreach (Item item in items)
            {
                if (item != null)
                     count++;
            }

            
            return count;
        }
    }

    public bool IsValid(int index)
    {
        return capacity > index && index >= 0;
    }

    public Item this[string name]
    {
        get
        {
            foreach (Item item in items)
            {
                if (item != null && item.Name == name)
                    return item;
            }
            return null;
        }
    }

    public Item this[int index]
    
    {
        get
        {
            if (IsValid(index))
                return items[index];
            
            throw new IndexOutOfRangeException();
        }

        set
        {
            if (IsValid(index))
                items[index] = value;
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public override string ToString()
    {
        Console.WriteLine("Inventory items:");
        
        string result = "";
        foreach (var item in items)
        {
           result += item + " ";
        }
        return result;
    }

    public IEnumerator GetEnumerator()
    {
        return new ItemIterator(items);
    }
}