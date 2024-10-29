/*
    - Inner class adalah class yang didefinisikan didalam class lain.

    - Inner class berfungsi untuk menjadikan class tersebut hanya dapat diakses
      di satu tempat secara logis, sehingga meningkatkan enkapsulasi sehingga
      mudah dibaca.

    - Beberapa poin penting dari inner class :
      - Inner class dapat didefinisikan berbagai macam access modifier.
      - Kelas luar tidak diizinkan untuk mengakses member inner class secara langsung.
      - Data private di kelas luar dapat diakses di kelas dalam.
      - Inner class dapat mengakses data static milik kelas luar.
      - Inner class dapat mengakses data non static milik kelas luar melalui
        referensi dari kelas luar.

*/

public class InnerClass
{
    public static void main()
    {
        Outer outer = new Outer();
        outer.print1();

        Outer.Inner inner = new Outer.Inner();
        inner.print2();
        inner.printName();
    }
}

class Outer
{
    public static string name;
    public int age;

    public Outer()
    {
        name = "mulyono";
        age = 35;
    }
    public void print1()
    {
        Console.WriteLine("kelas luar");
    }

    // mendefinisikan kelas dalam 
    public class Inner
    {
        public void print2()
        {
            Console.WriteLine("kelas dalam");
        }

        public void printName()
        {
            // mendefinisikan instance dari kelas luar.
            Outer outer = new Outer();

            Console.WriteLine("Nama saya " + Outer.name);
            Console.WriteLine("Usia " + outer.age);
        }
    }
}
