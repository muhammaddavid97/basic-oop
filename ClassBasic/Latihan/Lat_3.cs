public class Lat3
{
    public static void main()
    {
        string text = swapping('h', 'e', 'l', 'l', 'o');

        Console.WriteLine(text);
    }

    public static string swapping(params char[] text)
    {
        int l = 0;
        int r = text.Length - 1;

        while(text[l] != text[r])
        {
            char swapp = text[l];
            text[l] = text[r];
            text[r] = swapp;

            l++;
            r--;
        }

        string temp = new string(text);

        return temp;
    }

}