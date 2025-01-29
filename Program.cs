using System;
using System.Collections.Generic;
using System.Diagnostics;

Random random = new Random();

// BUBBLESORT
List<int> list10 = GenerateRandomList(10, random);
List<int> list100 = GenerateRandomList(100, random);
List<int> list1000 = GenerateRandomList(1000, random);
List<int> list10000 = GenerateRandomList(10000, random);
List<int> list100000 = GenerateRandomList(100000, random);

long time = RunBubblesort(list10);
Console.WriteLine($"Tid för bubblesort lista med 10 element: {time} ms");

time = RunBubblesort(list100);
Console.WriteLine($"Tid för bubblesort lista med 100 element: {time} ms");

time = RunBubblesort(list1000);
Console.WriteLine($"Tid för bubblesort lista med 1000 element: {time} ms");

time = RunBubblesort(list10000);
Console.WriteLine($"Tid för bubblesort lista med 10000 element: {time} ms");

time = RunBubblesort(list100000);
Console.WriteLine($"Tid för bubblesort lista med 100000 element: {time} ms");

//INSERTIONSORT
list10 = GenerateRandomList(10,random);
list100 = GenerateRandomList(100,random);
list1000 = GenerateRandomList(1000,random);
list10000 = GenerateRandomList(10000,random);
list100000 = GenerateRandomList(100000,random);

time = RunInsertionSort(list10);
Console.WriteLine($"Tid för insertionsort lista med 10 element: {time} ms");

time = RunInsertionSort(list100);
Console.WriteLine($"Tid för insertionsort lista med 100 element: {time} ms");

time = RunInsertionSort(list1000);
Console.WriteLine($"Tid för insertionsort lista med 1000 element: {time} ms");

time = RunInsertionSort(list10000);
Console.WriteLine($"Tid för insertionsort lista med 10000 element: {time} ms");

time = RunInsertionSort(list100000);
Console.WriteLine($"Tid för insertionsort lista med 100000 element: {time} ms");


static List<int> GenerateRandomList(int size, Random random)
{
    List<int> list = new List<int>(size);
    for (int i = 0; i < size; i++)
    {
        list.Add(random.Next(0, 1001)); 
    }
    return list;
}


static long RunBubblesort(List<int> list)
{
    Stopwatch bubblewatch = new Stopwatch();
    bubblewatch.Start();

    for (int i = 0; i < list.Count - 1; i++)
    {
         for (int j = 0; j < list.Count - 1 - i; j++)
         {
            if (list[j] > list[j + 1])
            {
                int temp = list[j];
                list[j] = list[j + 1];
                list[j + 1] = temp;
            }
        }
    }
    bubblewatch.Stop();
    return bubblewatch.ElapsedMilliseconds;
}


static long RunInsertionSort(List<int>list)
{
    Stopwatch insertionwatch = new Stopwatch();
    insertionwatch.Start();

    for (int i = 1; i < list.Count; i++)
    {
        int key = list[i], j = i - 1;
        while (j >= 0 && list[j] > key)
        {
            list[j + 1] = list[j];
            j--;
        }
         list[j + 1] = key;
    }
    insertionwatch.Stop();
    return insertionwatch.ElapsedMilliseconds;
}