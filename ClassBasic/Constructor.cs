/*
    - Constructor adalah method khusus yang dipanggil ketika proses instansiasi 
      suatu class.
    
    - Constructor didefinisikan dengan nama yang sama dengan nama kelasnya.

    - Constructor tidak memiliki tipe baik itu void maupun mengembalikan nilai.

    - Jika suatu class tidak mendefinisikan constructor secara eksplisit maka
      secara otomatis default constructor dipanggil, namun ketika constructor 
      dibuat maka default constructor akan ditimpa.

*/

public class Constructor
{
    public static void main()
    {
        PersegiPanjang persegiPanjang = new PersegiPanjang(7, 11);

        Console.WriteLine("Luas persegi panjang = " + persegiPanjang.luas());
        Console.WriteLine("Keliling persegi panjang = " + persegiPanjang.keliling());
    }
}
class PersegiPanjang
{
    int panjang;
    int lebar;

    // mendefinisikan constructor parameter
    public PersegiPanjang(int panjang, int lebar)
    {
        this.panjang = panjang;
        this.lebar = lebar;
    }

    public double luas()
    {
        return this.panjang * this.lebar;
    }

    public double keliling()
    {
        return 2 * (this.panjang + this.lebar);
    }
}