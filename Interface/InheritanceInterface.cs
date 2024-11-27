using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Interface
{

    /*
        - Suatu interface dapat diwariskan (inheritance) lebih dari satu interface sama halnya 
          seperti kelas.
     */
    public class InheritanceInterface
    {
        public static void main()
        {

            Person person = new Person();

            IDataPerson[] dataPerson = new Person[]
            {
                new Person("Ganjar", 34, "Solo"),
                new Person("Ujang", 45, "Jakarta")
            };

            person.AddNewPerson(dataPerson);

            List<IPerson> tempPersons = person.Persons;

            for (int i = 0; i < tempPersons.Count; i++) 
            {
                Console.WriteLine($"Nama : {tempPersons[i].Name} \nUsia : {tempPersons[i].Age} \nAlamat : {tempPersons[i].Address}");
            }
        }
    }

    interface IPerson 
    {
        string Name { set; get; }
        int Age { set; get; }
        string Address { set; get; }

    }
    interface IDataPerson : IPerson
    {
        List<IPerson> Persons { set; get; }
    }

    class Person : IDataPerson 
    {
        private string name;
        private int age;
        private string address;
        private List<IPerson> persons;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age 
        {
            set {  age = value; }
            get { return age; }
        }
        public string Address 
        {
            set {  address = value; }
            get { return address; }
        }
        public List<IPerson> Persons 
        {
            set {  persons = value; }
            get { return persons; }
        }
        public Person(string name, int age, string address) 
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public Person() 
        {
            this.Persons = new List<IPerson>();
        }
        public List<IPerson> AddNewPerson(IDataPerson[] person) 
        {

            for (int i = 0; i < person.Length; i++) 
            {
                this.persons.Add(person[i]);
            }

            if (this.persons.Count <= 0)
            {
                Console.WriteLine("Data is not invalid");
            }

            return this.persons;
        }
    }
}
