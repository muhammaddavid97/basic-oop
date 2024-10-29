public class Lat5
{
    public static void main()
    {
        Circle2 circle2 = new Circle2();
        circle2.print();
    }
}

class Circle2
{
    private const double PI = Math.PI;
    private static int radius;

    public class InnerClassCircle
    {
        public InnerClassCircle()
        {
            radius = 8;
        }
        public double luas()
        {
            return PI * Math.Pow(radius, 2); 
        }
        public double keliling()
        {
            return 2 * PI * radius;
        }
    }

    public void print()
    {
        InnerClassCircle innerClassCircle = new InnerClassCircle();

        Console.WriteLine("Luas lingkaran = " + innerClassCircle.luas());
        Console.WriteLine("Keliling lingkaran = " + innerClassCircle.keliling());
    }
}