/*
    - Hierarchy Inheritance adalah proses pewarisan dimana satu kelas parent dapat 
      mewarisi lebih dari satu kelas anak.
*/

public class HierarchyInheritance
{
    public static void main()
    {
        Siswa2 siswa2 = new Siswa2("yunus", 14, "susukan");
        siswa2.nilai = 5.5;

        Pejabat pejabat = new Pejabat("bahlil ulum", 54, "kebon jeruk");
        pejabat.jabatan = "ketua partai golkar";

        Console.WriteLine(siswa2.ToString());
        Console.WriteLine(pejabat.ToString());
    }
}
class Manusia2
{
    public string nama;
    public int usia;
    public string alamat;
}

class Siswa2 : Manusia2
{
    public double nilai;
    public Siswa2(string nama, int usia, string alamat)
    {
        this.nama = nama;
        this.usia = usia;
        this.alamat = alamat;
    }

    public override string ToString()
    {
        return $"Nama {this.nama}\n Usia {this.usia}\n Alamat {this.alamat}\n Nilai ujian {this.nilai}";
    }
}

class Pejabat : Manusia2
{
    public string jabatan;

    public Pejabat(string nama, int usia, string alamat)
    {
        this.nama = nama;
        this.usia = usia;
        this.alamat = alamat;
    }

    public override string ToString()
    {
        return $"Nama {this.nama}\n Usia {this.usia}\n Alamat {this.alamat}\n Jabatan sebagai {this.jabatan}"; 
    }
}