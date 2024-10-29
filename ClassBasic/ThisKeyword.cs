/*
    - This adalah keyword yang berfungsi untuk memanggil objek saat ini (dirinya sendiri).

    - This merujuk ke objek saat ini sehingga member class didalamnya dapat diakses
      menggunakan kata kunci this.
*/


public class ThisKeyword {

    public static void main()
    {
        Stack obj = new Stack();

        obj.push(4);
        obj.push(1);
        obj.push(9);
        obj.push(0);

        obj.print();
    }
}

class Stack
{
    const int max = 3;
    int[] items = new int[max];
    int top;

    public void push(int elemen)
    {
        // memanggil method dengan this
        bool isFull = this.isFull();

        if (isFull)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }

        this.items[top++] = elemen;
    }

    public bool isFull()
    {
        if (top >= max)
        {
            return true;
        }

        return false;
    }

    public void print()
    {
        for (int i = 0; i < this.top; i++)
        {
            Console.WriteLine(this.items[i]);
        }
    }
}
