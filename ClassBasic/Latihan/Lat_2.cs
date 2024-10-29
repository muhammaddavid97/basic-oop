public class Lat2
{
    public static void main()
    {
        Student student = new Student();
        student.print();
    }
}

class Student
{
    string nama;
    int age;

    public Student()
    {
        this.nama = "asep";
        this.age = 56;
    }

    public void print()
    {
        Console.WriteLine("Nama : " + this.nama);
        Console.WriteLine("Usia : " + this.age);
    }
}