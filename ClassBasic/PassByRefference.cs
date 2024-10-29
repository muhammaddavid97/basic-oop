/*
    - Pass By Refference adalah mekanisme dimana proses penyalinan dari argumen
      ke parameter method berdasarkan referensinya.

    - Sehingga argumen dan parameter method akan merujuk ke alamat memori yang sama.

    - Proses ini akan mempengaruhi perubahan nilai argumen yang terjadi pada 
      parameter method.

    - ref adalah keyword yang digunakan untuk mengubah tipe nilai menjadi tipe 
      referensi.
*/

public class PassByRefference
{
    public static void main()
    {
        string text = "kontol";

        Console.WriteLine("Sebelum tukar nilai");
        Console.WriteLine("text is " + text);

        Console.WriteLine("Setelah tukar nilai");
        tukarKata(ref text);
        Console.WriteLine("text is " + text);
    }

    public static void tukarKata(ref string text)
   {
        char[] temp = text.ToCharArray();
        int l = 0;
        int r = temp.Length - 1;

        while (l < r && r > l)
        {
            char swapp = temp[l];
            temp[l] = temp[r];
            temp[r] = swapp;

            l++;
            r--;
        }

        text = new string(temp);
   }
}

