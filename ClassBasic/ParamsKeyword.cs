/*
    - Params adalah keyword yang berfungsi untuk melewatkan lebih dari satu argumen
      meskipun parameter yang didefinisikan berjumlah satu.
*/

public class ParamsKeyword
{

    public static void main()
    {
        ParamsKeyword obj = new ParamsKeyword();

        int[] numbers = obj.sortingNumbers(3, 1, 9, 5, 2);

        foreach(var item in numbers) Console.WriteLine(item);
    }

    public int[] sortingNumbers(params int[] nums)
    {
        int[] temp = new int[nums.Length];
        int count = 0;

        // sorting numbers
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[min] > nums[j])
                {
                    min = j;
                }
            }

            int swapp = nums[i];
            nums[i] = nums[min];
            nums[min] = swapp;
        }

        foreach(var item in nums)
        {
            temp[count] = item;

            count++;
        }

        return temp;
    }

}
