/*
    - Protected adalah sebuah tipe akses yang berfungsi untuk membungkus method
      atau property dimana property atau method yang didefinisikan dengan protected
      hanya dapat diakses oleh kelas itu sendiri dan kelas turunannya.
*/

public class ProtectedModifier
{
    public static void main()
    {
        Lingkaran2 lingkaran2 = new Lingkaran2(5);
        Console.WriteLine(lingkaran2.ToString());
    }
}

class BangunDatar
{
    protected double luas;
    protected double keliling;
}

class Lingkaran2 : BangunDatar
{
    private const double PI = Math.PI;
    private int radius;
    public Lingkaran2(int radius)
    {
        this.radius = radius;
    }
    public void setRadius(int radius)
    {
        this.radius = radius;
    }
    public int getRadius()
    {
        return this.radius;
    }
    
    public double luasLingkaran()
    {
        this.luas = PI * Math.Pow(this.radius, 2);

        return this.luas;
    }

    public double kelilingLingkaran()
    {
        this.keliling = 2 * PI * this.radius;

        return this.keliling;
    }

    public override string ToString()
    {
        return $"Luas lingkaran = {this.luasLingkaran()}" + $"\n Keliling lingkaran = {this.kelilingLingkaran()}";
    }
}