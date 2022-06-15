//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6



using System;
using static System.Console;
Clear();
Write("Введите трехзначное число:");
int  number=Convert.ToInt32(ReadLine());
WriteLine(number);
if (number>100)
{
    Console.WriteLine(number.ToString()[2]);
}
else
{
    Write("Нету 3 цифры");
}

