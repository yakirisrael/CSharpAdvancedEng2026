using System.Collections;

namespace Lesson04;

public class ItemIterator : IEnumerator
{
    int position = -1;
    
    Item[] items;

    public ItemIterator(Item[] items)
    {
        this.items = items;
    }

    public bool MoveNext()
    {
       

        position++;
        
        while (position < items.Length && items[position] == null )
            position++;
        
        return position < items.Length;
    }

    public void Reset()
    {
        position = -1;
    }

    public object? Current
    {
        get
        {
            if (position < 0 || position >= items.Length)
                return null;
            
            
          
            return items[position];
        }
    }
}