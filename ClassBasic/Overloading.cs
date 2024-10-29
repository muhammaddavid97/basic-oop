/*
    - Overloading adalah proses pendefinisian dua buah method atau lebih 
      dengan nama yang sama tetapi parameternya beda.

    - Perbedaan parameter mencakup :
      - Jumlahnya sama tapi tipe datanya berbeda.
      - Jumlahnya berbeda tapi tipe datanya sama.
      - Kombinasi dari keduanya.

    - Proses overloading tidak mendukung berdasarkan tipe pengembalian methodnya.

    - Overloading juga berlaku untuk constructor dengan parameter yang berbeda.
*/

public class Overloading
{
    public static void main()
    {
        Lingkaran lingkaran = new Lingkaran();

        lingkaran.print();

        Employee employee1 = new Employee("david", "cirebon");
        employee1.print();
        Console.WriteLine("Gaji pokok = Rp." + new Employee(45000).totalGajiPokok());
        
    }
}

class Lingkaran
{
    const double PI = 3.14;
    public double luas(int radius)
    {
        return PI * Math.Pow(radius, 2);
    }
    public double luas(double radius)
    {
        return PI * Math.Pow(radius, 2);
    }

    public void print()
    {
        int a = 3;
        double b = 3.5;

        Console.WriteLine("Luas lingkaran pertama = " + this.luas(a));
        Console.WriteLine("Luas lingkaran kedua = " + this.luas(b));
    }
}

class Employee
{
    private string nama;
    private string alamat;
    private double gapok;
    
    public Employee(string nama, string alamat)
    {
        this.nama = nama;
        this.alamat = alamat;
    }

    public Employee(double gapok)
    {
        this.gapok = gapok;
    }

    public double totalGajiPokok()
    {
        return 30 * this.gapok;
    }

    public void print()
    {
        Console.WriteLine("Nama : " + this.nama);
        Console.WriteLine("Alamat : " + this.alamat);
    }
}