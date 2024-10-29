/*
    - Inheritance adalah salah satu konsep dala paradigma pemrograman berorientasi objek
      dimana suatu kelas dapat mewarisi sifat yang dimiliki oleh kelas lain.

    - Kelas dasar atau based class adalah sebuah kelas induk dimana nantinya semua member
      kelas ini dapat diwariskan kedalam kelas lainnya.

    - Kelas anak atau derived class adalah kelas yang nantinya akan mewarisi sifat sifat
      yang dimiliki oleh kelas parentnya. 

    - Dalam inheritance ketika objek dari kelas turunan dibuat maka objek yang pertama 
      kali dipanggil adalah objek milik kelas parentnya lalu diikuti dengan objek turunannya.
*/

public class InheritanceBasic
{
    public static void main()
    {
        Siswa siswa = new Siswa("jokowi", 34);
        siswa.print();

        Mahasiswa mahasiswa = new Mahasiswa("david", 35, 3.4);
        mahasiswa.print();

        Console.WriteLine("Objek kelas A dibuat");
        A2 a = new A2();
        Console.WriteLine("Objek kelas B dibuat");
        B2 b = new B2();
        Console.WriteLine("Objek kelas C dibuat");
        C2 c = new C2();

    }
}

class People
{
    public string name;
    public int age;
}

// kelas Siswa mewarisi kelas People
class Siswa : People
{
    public double nilaiUjian;
    public Siswa(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Siswa(double nilaiUjian)
    {
        this.nilaiUjian = nilaiUjian;
    }
    public void print()
    {
        Console.WriteLine("Nama " + this.name);
        Console.WriteLine("Usia " + this.age);
        Console.WriteLine("Nilai ujian " + this.nilaiUjian);
    }
}

class Mahasiswa : Siswa
{
    public Mahasiswa(string name, int age, double nilaiUjian) : base(nilaiUjian)
    {
        this.name = name;
        this.age = age;
        this.nilaiUjian = nilaiUjian;
    }
}

class A2
{
    public A2()
    {
        Console.WriteLine("Objek kelas A");
    }
}

class B2 : A2
{
    public B2()
    {
        Console.WriteLine("Objek kelas B");
    }
}

class C2 : B2
{
    public C2 ()
    {
        Console.WriteLine("Objek kelas C");
    }
}