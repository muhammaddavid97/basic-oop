/*
    - Private adalah Access modifier dimana class atau member suatu class yang 
      didefinisikan dengan private hanya bisa diakses didalam file yang sama atau
      class itu sendiri.

    - Umumnya data atau field class bersifat private agar tidak rusak sehingga
      field bisa diakses melalui method atau property.
*/

public class PrivateModifier
{
    public static void main()
    {
        Person person = new Person("Yudi", 28);

        person.print();
    }
}

class Person
{
    private string nama;
    private int usia;
    public Person(string nama, int usia)
    {
        this.nama = nama;
        this.usia = usia;
    }

    public void print()
    {
        Console.WriteLine("Nama : " + this.nama);
        Console.WriteLine("Usia : " + this.usia);
    }
}