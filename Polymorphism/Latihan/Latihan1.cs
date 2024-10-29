public class Latihan1Polymorp
{
    public static void main()
    {
        NewPerson3 newPerson3 = new NewPerson3();

        Person3[] person3s = new Person3[]
        {
            new Person3("david", 31),
            new Person3("yunus", 12)
        };
  
        foreach(var item in person3s)
        {
            newPerson3.pushData(item);
        }

        Console.WriteLine("Menampilkan data person");
        newPerson3.printData();
    }
}

class Person3
{
    public string Name{get; set;}
    public int Age{get; set;}
    public Person3(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Person3()
    {

    }
}
abstract class StackPerson : Person3
{
   public int Top {get; set;}
   public abstract void pushData(Person3 person3);
   public abstract Person3 popData();
}

class NewPerson3 : StackPerson
{
    private const int max = 4;
    private Person3[] Person3s;
    public NewPerson3()
    {
        this.Person3s = new Person3[max];
    }
    public override void pushData(Person3 person3)
    {
        if (this.Top >= max)
        {
            Console.WriteLine("Maximum data");
            return;
        }

        this.Person3s[this.Top] = person3;
        this.Top++;
    }
    public override Person3 popData()
    {
       if (this.Top <= 0)
       {
        Console.WriteLine("Data is empty");
        return new Person3();
       }

       Person3 temp = this.Person3s[this.Top];

       this.Top--;

       return temp;
    }
    
    public void printData()
    {
        bool condition = true;
        this.Person3s[this.Top] = new Person3();

        while(condition)
        {
            if (this.Top < 0)
            {
                condition = false;
            }

            Console.WriteLine("Nama : " + this.Person3s[this.Top].Name + "\n" + "Usia : " + this.Person3s[this.Top].Age);

            this.Top--;
        }
    }

}