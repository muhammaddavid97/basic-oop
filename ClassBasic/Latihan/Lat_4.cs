public class Lat4
{
   public static void main()
   {
        Students student = new Students("yusuf", 21);
        student.print(student);
   }
}

public class Students
{
    private string name;
    private int age;

    public Students(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void print(Students student)
    {
        Console.WriteLine("Nama : " + student.name);
        Console.WriteLine("Usia : " + student.age);
    }
}