//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1





using System;
using static System.Console;
Clear();
Write("Введите трехзначное число:");
int  number=Convert.ToInt32(ReadLine());
WriteLine(number);
Console.WriteLine(number.ToString()[1]);