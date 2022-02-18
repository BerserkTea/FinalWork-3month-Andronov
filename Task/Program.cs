﻿// *Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
Console.Clear();
string[] arrayStrings = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

string[] SortStringArrayLess4Digits(string[] stringtosort)
{
    int counterDigits = 0;
    for (int i = 0; i < stringtosort.Length; i++)
    {
        if (stringtosort[i].Length < 4)
        {
            counterDigits++;
        }
    }

    string[] sortedArray = new string[counterDigits];
    for (int j = 0; j < stringtosort.Length; j++)
    {
        int digitCounterSortedArray = 0;
        if (stringtosort[j].Length < 4)
        {
            sortedArray[digitCounterSortedArray] = stringtosort[j];
            digitCounterSortedArray++;
        }
    }
    return sortedArray;
}
void PrintStringArray(string[] stringarray)
{
    for (int i = 0; i < stringarray.Length; i++)
    {

        Console.Write($"{stringarray[i]} ");

        Console.WriteLine();
    }
}
PrintStringArray(arrayStrings);
PrintStringArray(SortStringArrayLess4Digits(arrayStrings));