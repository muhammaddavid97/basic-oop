public class Latihan1
{
    public static void main()
    {
        LingkaranA lingkaranA = new LingkaranA(3);
        Console.WriteLine("Radius = " + lingkaranA.getRadius());
        Console.WriteLine("Luas = " + lingkaranA.luas());
    }
}

class Lingkaran3
{
    protected const double PI = Math.PI;
    protected double radius;
    public double getRadius(){ return this.radius; }
    public double luas()
    {
        return PI * Math.Pow(this.getRadius(), 2);
    }
}

class LingkaranA : Lingkaran3
{
    public LingkaranA(double radius)
    {
        this.radius = radius;
    }

    public double luas()
    {
        return base.luas();
    }
}