//task1
//int[] arr = { -1, 2, -3, 4, -5 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < 0)
//    {
//        arr[i] = -arr[i];
//    }
//    if (i < arr.Length - 1)
//        Console.Write($"{arr[i]},");
//    else
//        Console.Write(arr[i]);
//}


//task2
//int[] arr = { 1, 0, 2, 0, 3 };
//int n = arr.Length;
//int index = n - 1;
//for (int i = n - 1; i >= 0; i--)
//{
//    if (arr[i] != 0)
//    {
//        arr[index] = arr[i];
//        index--;
//    }
//}
//while (index >= 0)
//{
//    arr[index] = 0;
//    index--;
//}
//for (int i = 0; i < arr.Length; i++)
//    if (i < arr.Length - 1)
//    Console.Write($"{arr[i]},");
//else
//    Console.Write(arr[i]);