/*
    - Override adalah sebuah mekanisme dimana suatu method didefinisikan didalam kelas parent
      diperbarui / dimodifikasi sifatnya di dalam kelas turunannya.
    
    - Dalam proses overriding method di kelas dasar secara pendefinisian harus sama persis
      dilakukan di dalam kelas turunannya.
    
    - Virtual adalah keyword yang didefinisikan untuk proses override terhadap 
      method yang dimiliki kelas parentnya.
    
    - Override adalah keyword yang didefinisikan untuk proses override tehadap 
      method yang dimiliki kelas childnya.
*/

public class MethodOverride
{
    public static void main()
    {
        Segitiga2 obj = new Segitiga2(4, 2);
        Console.WriteLine(obj.ToString());
    }
}

class BangunDatar2
{
    public virtual double luas(){return 0;}
}

class Segitiga2 : BangunDatar2
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
    public Segitiga2(int alas, int tinggi)
    {
        this.alas = alas;
        this.tinggi = tinggi;
    }
    public override double luas()
    {
        return 0.5 * (this.alas * this.tinggi);
    }
    public override string ToString()
    {
        return $"Luas = {this.luas()}";
    }
}