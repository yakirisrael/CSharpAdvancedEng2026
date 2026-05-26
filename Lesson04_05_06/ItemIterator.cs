using System.Collections;

namespace Lesson04;

public class ItemIterator<T> : IEnumerator
{
    int position = -1;
    
    Inventory<T> inventory;

    public ItemIterator(Inventory<T> inventory)
    {
        this.inventory = inventory;
    }

    public bool MoveNext()
    {
        position++;
        
        while (position < inventory.Capacity && inventory[position] == null )
            position++;
        
        return position < inventory.Capacity;
    }

    public void Reset()
    {
        position = -1;
    }

    public object? Current
    {
        get
        {
            if (position < 0 || position >= inventory.Capacity)
                return null;
          
            return inventory[position];
        }
    }
}