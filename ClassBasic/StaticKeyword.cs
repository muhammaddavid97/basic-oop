/*
    - Static adalah keyword yang dapat didefinisikan pada saat mendeklarasikan 
      member didalam suatu class.
    
    - Static berfungsi untuk mengubah member didalam class yang secara umum milik
      objek dari kelas menjadi milik class itu sendiri.

    - Member static dapat di sharing untuk semua objek dari kelas tersebut.

    - Setiap member kelas yang didefinisikan dengan keyword static dapat dipanggil
      tanpa harus membuat instance dari kelas melainkan menggunakan nama kelasnya.
    
    - Beberapa constraint terkait pendefinisian method static : 
      - Method static hanya dapat memanggil method lain yg bersifat static.
      - Method static hanya dapat mengakses field static.
      - Method static  tidak dapat dipanggil dengan keyword this.
*/

public class StaticKeyword
{
   public static void main()
   {
      int[] items = new int[] {5, 1, 3, 9, 0};
      int target = 5;

      int temp = linearSearch(items, 0, target);

      Console.WriteLine("Target is " + temp);
   }

   public static int linearSearch(int[] items, int count, int target)
   {
      if (count >= items.Length)
      {
         return -1;
      }
      
      if (items[count] == target)
      {
        return items[count];
      }

      return linearSearch(items, count + 1, target);
   }
}

