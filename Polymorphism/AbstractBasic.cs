/*
    - Method abstract adalah sebuah method yang didefinisikan tanpa adanya 
      implementasi kode sama sekali jadi hanya berupa deklarinya saja.

    - Implementasi method abstract dapat dilakukan ketika method tersebut di 
      override di kelas turunannya.

    - Secara otomatis method yang didefinisikan dengan abstract akan bersifat
      override sehingga kita tidak perlu menambahkan keyword virtual.
    
    - Abstract adalah keyword yang nantinya digunakan sebagai modifier pada method 
      yang bersifat abstract.
    
    - Kelas abstract adalah kelas yang bersifat abstract dimana kelas ini berisi sekumpulan
      member (baik method atau property) yang bersifat abstract.

    - Kelas abstract didefinisikan dengan menggunakan keyword abstract.

    - Kelas abstract masih dapat mendefinisikan member non abstract didalamnya,

*/

public class AbstractBasic
{
  public static void main()
  {
    Karyawan karyawan = new Karyawan();

    Person2[] person2s = new Person2[] 
    {
      new Karyawan("udin",34),
      new Karyawan("isal", 23),
      new Karyawan("titi", 45),
      new Karyawan("roy", 33)
    };

    foreach(var item in person2s)
    {
      karyawan.AddNewPerson(item);
    }

    Console.WriteLine("Menampilkan data person");
    
    foreach(var item in karyawan.Person2s)
    {
      Console.WriteLine("Nama : " + item.name + "\n" + "Usia : " + item.age);
    }

    karyawan.DeletePerson("titi");

    Console.WriteLine("Menampilkan data person setelah proses hapus");

    foreach(var item in karyawan.Person2s)
    {
      Console.WriteLine("Nama : " + item.name + "\n" + "Usia : " + item.age);
    }
  }
}

abstract class Person2
{
  public string name;
  public int age;
  public Person2(string name, int age)
  {
    this.name = name;
    this.age = age;
  }
  public Person2()
  {

  }
  public abstract void AddNewPerson(Person2 person2);
  public abstract void DeletePerson(string name);
}

class Karyawan : Person2
{
  public List<Person2> Person2s{get; set;}
  public Karyawan(string name, int age) : base(name, age)
  {
    this.name = name;
    this.age = age;
  }
  public Karyawan()
  {
      this.Person2s = new List<Person2>();
  }
  public override void AddNewPerson(Person2 person2)
  {
     this.Person2s.Add(person2);
  }

  public override void DeletePerson(string name)
  {
    for (int i = 0; i < this.Person2s.Count; i++)
    {
      if (this.Person2s[i].name == name)
      {
          this.Person2s.RemoveAt(i);
          break;
      }
    }
  }
}

