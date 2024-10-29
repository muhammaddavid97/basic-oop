
/*
    - Kelas adalah Sebuah blue print atau cetak biru yang merepresentasikan
      suatu objek tertentu.

    - Kelas pada dasarnya merupakan tipe data baru yang digunakan mendeklarasikan
      variable yang menunjuk ke objek aktual yg disebut variable referensi.

    - Keyword new digunakan untuk proses pembuatan objek baru atau disebut instansiasi.

    -  Anggota kelas terdiri atas :
      - field => disebut sebagai data atau atribut kelas.
      - method => fungsi yang didefinisikan didalam kelas.

   - Setiap membuat instansiasi maka masing2 variable referensi tersebut akan merujuk 
     ke objek  yang berbeda hal ini setiap variable referensi disimpan di alamat memori
     yang berbeda.
   
   - Jika suatu referensi diisi oleh referensi maka hal tersebut tidak akan menciptakan
     objek baru melainkan hanya membuat salinan referensinya saja. 
*/

public class ClassBasic
{
    public static void main()
    {
       // proses instansiasi kelas Manusia
       Manusia obj = new Manusia();
       obj.nama = "yudi";
       obj.usia = 20;
       obj.alamat = "bandung";

       obj.tampilData();
       
       // deklarasi salinan referensi.
       Manusia manusia1 = new Manusia();
       manusia1.nama = "yono";
       manusia1.usia = 19;
       manusia1.alamat = "cirebon";

       Manusia manusia2 = null;
       manusia2 = manusia1;

       manusia2.tampilData();
    }
}

class Manusia
{
    // deklarasi field kelas
    public string nama;
    public int usia;
    public string alamat;

    // deklarasi method kelas
    public void tampilData()
    {
        Console.WriteLine("Nama : " + this.nama);
        Console.WriteLine("Usia : " + this.usia);
        Console.WriteLine("Alamat : " + this.alamat);

    }
}