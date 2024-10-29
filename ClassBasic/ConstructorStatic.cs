/*
    - Constructor static adalah constructor yang didefinisikan dengan keyword
      static
    
    - Constructor static tidak perlu menggunakan access modifier pada pendefinisiannya.
    
    - Constructor static  dipanggil secara otomatis ketika pertama kali kelas 
      digunakan.
    
    - Constructor static biasanya digunakan untuk mendefinisikan data atau field 
      static.

*/

public class ConstructorStatic
{
    public static void main()
    {
        Circle obj = new Circle(3);

        Console.WriteLine("Luas lingkaran = " + obj.luas());
    }
}

class Circle
{
    static double PI;
    public int radius;

    static Circle()
    {
        PI = 3.14;
    }
    public Circle(int radius)
    {
        this.radius = this.radius;
    }

    public double luas()
    {
        return PI * Math.Pow(this.radius, 2);
    }
}