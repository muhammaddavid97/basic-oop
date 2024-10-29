/*
    - Sealed adalah keyword yang didefinisikan sebagai modifier baik pada class
      atau pada method.

    - Sealed memiliki fungsi sebagai berikut :

      - Jika didefinisikan pada method maka sealed akan mencegah supaya method
        tersebut tidak dapat di override ke kelas turunannya.

      - Jika didefinisikan pada class maka sealed akan mencegah supaya class tersebut 
        tidak dapat diwariskan.
*/

public class SealedKeyword
{
    public static void main()
    {
        A3 a3 = new A3();
        a3.print();
    }
}

class A3
{
    public virtual void print()
    {

    }
}

class B3 : A3
{
    sealed public override void print()
    {
        Console.WriteLine("Method ini milik B3");
    }
}

class C3 : B3
{

    // menampilkan pesan error sebab method B3.print() didefinisikan sebagai sealed
    //public override void print(){}
}

class TestA
{

}

sealed class TestB : TestA
{

}

// menampilkan pesan error karena class TestB didefinisikan sebagai sealed
//class TestC : TestB{}