using System;

class Delegate
{

    public delegate bool Compare(int a, int b);
    public static void MySort(int[] array, Compare compare)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (compare(array[i], array[j]))
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}
