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
//        Console.Write($"{arr[i]},");
//    else
//        Console.Write(arr[i]);






//task3
//string input = Console.ReadLine();
//string[] inputs = input.Split(',');
//int[] mass = new int[inputs.Length];
//for (int i = 0; i < inputs.Length; i++)
//{
//    mass[i] = int.Parse(inputs[i].Trim());
//}
//int[] longestS = new int[0];
//int[] currentS = new int[inputs.Length];
//int maxL = 0;
//int currentL = 0;
//for (int a=0; a < mass.Length;a++)
//{
//    for ( int i = 0; i < mass.Length-1; i++)
//    {
//        int k = a;
//        currentL = 1;
//        currentS[0] = mass[a];
//        for (int j = i + 1; j < mass.Length; j++)
//        {
//            if (mass[j] > mass[k])
//            {
//                k = j;
//                currentS[currentL] = mass[j];
//                currentL++;
//            }
//        }
//        if (currentL >= maxL)
//        {
//            maxL = currentL;
//            longestS = new int[currentL];
//            Array.Copy(currentS, longestS, currentL);
//        }
//    }
//}
//for (int i = 0; i < longestS.Length; i++)
//{
//    if (i < longestS.Length - 1)
//        Console.Write($"{longestS[i]},");
//    else
//    Console.Write(longestS[i]);
//}