/*
    - Multiple Inheritance adalah pewarisan dimana kelas anak mewarisi lebih 
      dari satu kelas induk dan mewarisi semua fitur yang dimiliki kelas induk.

    - C# tidak mendukung proses multiple inheritance akan tetapi kita bisa lakukan dengan 
      menggunakan interface.
*/

public class MultipleInheritance
{
    public static void main()
    {
        C c = new C();
        
        c.getA();
        c.getB();
    }
}

interface A
{
    void getA();
}

interface B : A
{
    void getB();
}

class C : B
{
    public void getA()
    {
        Console.WriteLine("Memanggil method A");
    }

    public void getB()
    {
        Console.WriteLine("Memanggil method B");
    }
}