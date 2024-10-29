/*
    - PassByValue adalah mekanisme dimana sebuah proses penyalinan data dari argumen
      ke parameter sebuah method berdasarkan nilainya.
    
    - PassByValue tidak akan mempengaruhi perubahan nilai pada argumen ketika nilai
      parameter methodnya berubah.

    - Hal ini dikarenakan argumen dan parameter menempati alamat memory yang terpisah.
*/
public class PassByValue
{
   public static void main()
   {
        int x = 5;
        int y = 10;

        Console.WriteLine("Sebelum tukar nilai");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        Console.WriteLine("Setelah tukar nilai");
        swappingValue(x, y);
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

   }

   public static void swappingValue(int a, int b)
   {
        int swapp = a;
        a = b;
        b = swapp;
   }
}