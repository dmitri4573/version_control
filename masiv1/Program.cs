﻿// //Итак, перейдём к первой задаче. В ней требуется заполнить массив целыми
// числами от 1 до N, где N – некоторое натуральное число и вывести его на экран.
// Давайте выделим этапы решения этой задачи, сформируем блок-схему и оживим
// алгоритм на C#.




int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n) //(i < arr.Length)
{
    arr[i] = i + 1;    
    Console.Write($"{arr[i]} ");
    i = i + 1;
}