/*
    - Base adalah keyword yang merujuk referensi ke objek dari kelas induknya.
    
    - Base keyword biasa digunakan untuk mengakses member (konstruktor, method dan property) 
      yang dimiliki kelas parentnya didalam kelas anak.
*/

public class BaseKeyword
{
    public static void main()
    {
        Employee2 employee2 = new Employee2("gibran rakabuming", 4500000);
        employee2.print();
    }
}

class People2
{
    protected string name;
    public string getName()
    {
        return this.name;
    }
    public People2(string name)
    {
        this.name = name;
    }
}

class Employee2 : People2
{
    private double sallary;
    public double getSallary()
    {
        return this.sallary;
    }
    public Employee2(string name, double sallary) : base(name)
    {
        this.name = name;
        this.sallary = sallary;
    }

    public void print()
    {
        Console.WriteLine("Nama karyawan PT B " + this.getName());
        Console.WriteLine("Gaji pokok " + this.getSallary());
    }
}