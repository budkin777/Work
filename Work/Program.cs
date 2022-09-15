string[] arrayFirst = new string[4] {"hello", "2", "world", ":-)"};
string[] arraySecond = new string[4];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Filter(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[j] = arr1[i];
        j++;
        }
    }
}

PrintArray(arrayFirst);
Filter (arrayFirst, arraySecond);
PrintArray(arraySecond);