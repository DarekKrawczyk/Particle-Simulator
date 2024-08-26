public class Vector
{
    public double X;
    public double Y;
    public double Z;

    public double Length
    {
        get
        {
            return Math.Sqrt(this * this);
        }
    }

    public Vector()
    {
        X = 0; Y = 0; Z = 0;
    }

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector(Vector other)
    {
        X = other.X;
        Y = other.Y;
        Z = other.Z;
    }

    public static double operator * (Vector v1, Vector v2)
    {
        return (v1.X * v2.X) + (v1.Y * v2.Y) + (v1.Z * v2.Z);
    }

    public static Vector operator *(Vector v1, double scalar)
    {
        return new Vector((v1.X * scalar), (v1.Y * scalar), (v1.Z * scalar));
    }

    public static Vector operator + (Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector operator - (Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    /// <summary>
    /// Cross product.
    /// </summary>
    /// <param name="v1">First Vector</param>
    /// <param name="v2">Second Vector</param>
    /// <returns>New object with cross product.</returns>
    public static Vector operator & (Vector v1, Vector v2)
    {
        return new Vector(v1.Y * v2.Z - v1.Z * v2.Y,
                          v1.Z * v2.X - v1.X * v2.Z,
                          v1.X * v2.Y - v1.Y * v2.X);
    }

    public void Normalize()
    {
        double length = Length;
        if(length != 1)
        {
            Vector result = this * (1 / length);
            X = result.X; 
            Y = result.Y; 
            Z = result.Z;
        }
    }
}