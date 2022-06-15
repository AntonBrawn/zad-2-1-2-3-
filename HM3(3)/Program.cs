//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

using System;
using static System.Console;
Clear();
Write("Введите цифрой день недели:");
int  day=Convert.ToInt32(ReadLine());
if ((day <1)||(day>7))
{
    WriteLine("Ошибка!Введите число в диапозоне от 1 до 7");
    return;
}
if (day==1)
{
    WriteLine("Понедельник"); Write("Это не выходной");
    return;
} 
if (day==2) 
{
    WriteLine("Вторник"); Write("Это не выходной");
    return;
}   
if (day==3) 
{
    WriteLine("Среда"); Write("Это не выходной");
}
if (day==4) 
{   
     WriteLine("Четверг"); Write("Это не выходной");
}
if (day==5) 
{
     WriteLine("Пятница"); Write("Это не выходной");
}
if (day==6) 
{
        WriteLine("Суббота"); Write("Это  выходной");
}
if (day==7) 
{
        WriteLine("Воскресенье"); Write("Это  выходной");
}        
