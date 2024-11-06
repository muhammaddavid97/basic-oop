/*
    - Interface sama halnya seperti kelas dapat memiliki methods, property, event dan indexers
      sebagai anggotanya.
    
    - Interface hanya berisi deklarasi anggota saja tidak ada impelementasi didalamnya.

*/

public class InterfaceBasic{
    public static void main(){
        Lingkaran4 lingkaran4 = new Lingkaran4();
        
        lingkaran4.setRadius(12);
        lingkaran4.getRadius();
        
        Console.WriteLine(lingkaran4.ToString());
    }
}

interface IBangunDatar{

    double luas();
    double keliling();
}

class Lingkaran4 : IBangunDatar{

    private const double PI = Math.PI;
    private int radius;
    public void setRadius(int value){
        this.radius = value;
    }
    public int getRadius(){
        return this.radius;
    }

    public double luas(){
        return PI * Math.Pow(this.radius, 2);
    }
    public double keliling(){
        return 2 * PI * this.radius;
    }

    public override string ToString()
    {
        return $"Luas = {this.luas()} \nKeliling = ${this.keliling()}";
    }
}