namespace Lesson03;

public class Vector
{
    private float x, y, z;
    
    public Vector(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return "(" + x + ", " + y + ", " + z + ")";
    }

    public override bool Equals(object? obj)
    {
       if (obj == null) return false;
       
       if (obj.GetType() != this.GetType()) return false;

       Vector otherVector = (Vector)obj;

       return otherVector.x == this.x && 
              otherVector.y == this.y &&
              otherVector.z == this.z;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y, z);
    }
}