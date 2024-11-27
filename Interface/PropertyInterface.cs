using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Interface
{

    /*
        - Selain method property juga dapat di definisikan didalam interface sebagai property abstract.
        
        - Property tersebut nantinya dapat di implementasikan oleh kelas yang mengimplementasikan interface 
          tersebut.

        - Interface dapat dijadikan sebagai tipe referensi dimana nantinya referensi tersebut merujuk 
          ke objek dari kelas yang mengimplementasikan interface tersebut.

        - Sehingga referensi tersebut dapat mengakses ke member kelasnya.

     */
    public class PropertyInterface
    {
        public static void main()
        {
            Print print = new Print();

            print.print();
        }
    }

    interface BangunDatar 
    {
        double Luas {  get; set; }
        double Keliling { get; set; }
        string Type { get; set; }
        double HitungLuas();
        double HitungKeliling();
    }

    class Lingkaran : BangunDatar 
    {
        private double luas;
        private double keliling;
        private string type;
        public int Radius { get; set; }


        // implementation property Luas
        public double Luas
        {
            set { luas = value; }
            get { return luas; }
        }

        // implementation property Keliling
        public double Keliling
        {
            set { keliling = value; }
            get { return keliling; }
        }

        // implementation property Type
        public string Type
        {
            set {  type = value; }
            get { return type; }
        }
        public Lingkaran(int radius, string type) 
        {
           this.Radius = radius;
           this.Type = type;
        }

        public double HitungLuas() 
        {
            this.luas = Math.PI * Math.Pow(2, this.Radius);
            return this.luas;
        }

        public double HitungKeliling() 
        {
            this.keliling = 2 * Math.PI * this.Radius;
            return this.keliling;
        }
    }

    class Persegi : BangunDatar 
    {
        private double luas;
        private double keliling;
        private string type;

        public int Sisi { get; set; }
        public double Luas
        {
            set { luas = value; }
            get { return luas; }
        }

        public double Keliling
        {
            set { keliling = value; }
            get { return keliling; }
        }
        public string Type
        {
            set { type = value; }
            get { return type; }
        }

        public Persegi(int sisi, string type) 
        {
            this.Sisi = sisi;
            this.type = type;
        }

        public double HitungLuas() 
        {
            this.Luas = Math.Pow(2, this.Sisi);
            return this.Luas;
        }

        public double HitungKeliling() 
        {
            this.keliling = 4 * this.Sisi;
            return this.keliling;
        }
    }

    class Print 
    {
        public void print() 
        {
            BangunDatar[] bangunDatars = new BangunDatar[]
            {
               new Lingkaran(11, "lingkaran"),
               new Persegi(2, "Persegi")
            };

            foreach (var item in bangunDatars) 
            {
                item.HitungLuas();
                item.HitungKeliling();

                Console.WriteLine($"Luas = {item.Luas} \nType : {item.Type}");
                Console.WriteLine($"Keliling = {item.Keliling} \nType : {item.Type}");
            }
        }
    }
}
