/*
    - Parameter opsional adalah parameter yang dapat diisi oleh nilai awal
      atau nilai default.

    - Dengan cara ini kita dapat memanggil method tanpa harus passing nilai argumen
      ke dalam method tersebut.

    - Sehingga yang akan digunakan sebagai argumen adalah nilai defaultnya.
*/

public class ParameterOpsional
{
    public static void main()
    {
        Student2 obj = new Student2("ijam", 11);
        Console.WriteLine(obj.nama);

        obj.print(); // tanpa argumen
        obj.print(obj.nama, obj.usia); // dengan argumen

    }
}

class Student2
{
    public string nama;
    public int usia;

    public Student2(string nama, int usia)
    {
        this.nama = nama;
        this.usia = usia;
    }

    public void print(string nama = "udin", int usia = 8)
    {
        this.nama = nama;
        this.usia = usia;

        Console.WriteLine("Nama " + this.nama);
        Console.WriteLine("Usia : " + this.usia);
    }
}