using System.Runtime.Intrinsics.X86;

public class Lat1
{
    public static void main()
    {
        SegiEmpat se1 = new SegiEmpat();
        se1.panjang = 10;
        se1.lebar = 5;

        SegiEmpat se2 = new SegiEmpat();
        se2.panjang = 5;
        se2.lebar = 10;

        Console.WriteLine("Luas segi empat 1 = " + se1.luas());
        Console.WriteLine("Keliling segi empat 1 = " + se1.keliling());
        Console.WriteLine("Luas segi empat 2 = " + se2.luas());
        Console.WriteLine("Keliling segi empat 2 = " + se2.keliling());

    }
}

class SegiEmpat
{
    public int panjang;
    public int lebar;

    public int luas()
    {
        return this.panjang * this.lebar;
    }

    public double keliling()
    {
        return 0.5 * (this.panjang + this.lebar);
    }
}