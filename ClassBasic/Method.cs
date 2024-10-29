/*

    - Method adalah fungsi yang dideklarsikan didalam suatu class.

    - Method dibagi menjadi 2  yaitu :
      - Method tanpa nilai balik 
      - Method dengan nilai balik

    - Method tanpa nilai balik adalah method yang tidak mengembalikan suatu nilai
    - Method dengan nilai balik adalah method yang mengembalikan suatu nilai.
    
    - void adalah keyword yang menunjukan suatu method tidak mengembalikan nilai.
      
    - Parameter adalah variable yang dimasukan ke dalam body method.

    - Method  parameter bersifat dinamis sehingga pada saat dipanggil method tersebut
      dapat menyimpan nilai yg berbeda dengan syarat harus sesua dengan tipe datanya.

*/

public class Method
{
    public static void main()
    {
       Segitiga obj = new Segitiga();

       obj.alas = 10;
       obj.tinggi = 9;

       obj.tampilLuas();
    }
}

class Segitiga
{
    public int alas;
    public int tinggi;
   
    // mendeklarasikan method nilai balik
    public double luas()
    {
        return (0.5) * (this.alas * this.tinggi);
    }

    // deklarasi method parameter
    public double keliling(int a, int t)
    {
        return 0.5 * (a + t);
    }
    
    // deklarasi method tanpa nilai balik
    public void tampilLuas()
    {
        int a = this.alas;
        int t = this.tinggi;

        Console.WriteLine("Luas segitiga = " + this.luas());
        Console.WriteLine("Keliling segitiga = " + this.keliling(a, t));
    }
}