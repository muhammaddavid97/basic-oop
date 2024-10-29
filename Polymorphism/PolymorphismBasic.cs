/*
    - Polymorphism adalah salah satu konsep dari paradigma OOP dimana memiliki
      arti banyak bentuk.

    - Polymorphism mengijinkan kita untuk membuat referensi dari kelas parentnya
      kemudian referensi tersebut dapat merujuk ke objek objek kelas turunannya.

    - Sehingga dengan satu deklarasi referensi dapat merujuk ke objek yang berbeda.
*/

public class PolymorphismBasic
{
    public static void main()
    {
        Bangun2D bangun2D;

        bangun2D = new Segitiga3(3, 2);
        Console.WriteLine(bangun2D.ToString());

        bangun2D = new Persegi(5);
        Console.WriteLine(bangun2D.ToString());

    }
}

abstract class Bangun2D
{
    abstract public double luas();
    abstract public double keliling();
}

class Segitiga3 : Bangun2D
{
    private int alas;
    private int tinggi;
    public int getAlas()
    {
        return this.alas;
    }
    public int getTinggi()
    {
        return this.tinggi;
    }
    public Segitiga3(int alas, int tinggi)
    {
        this.alas = alas;
        this.tinggi = tinggi;
    }
    public override double luas()
    {
        return (0.5) * (this.alas * this.tinggi);
    }
    public override double keliling()
    {
        return 2 * (this.alas + this.tinggi);
    }
    public override string ToString()
    {
        return $"Luas = {this.luas()}" + "\n" + $"Keliling = {this.keliling()}";
    }
}

class Persegi : Bangun2D
{
    private int sisi;
    public int getSisi()
    {
        return this.sisi;
    }
    public Persegi(int sisi)
    {
        this.sisi = sisi;
    }
    public override double luas()
    {
        return Math.Pow(this.sisi, 2);
    }
    public override double keliling()
    {
        return 4 * this.sisi;
    }
     public override string ToString()
    {
        return $"Luas = {this.luas()}" + "\n" + $"Keliling = {this.keliling()}";
    }
}