﻿// Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Напишите первое число: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Напишите второе число: ");
int second = int.Parse(Console.ReadLine());

if(first % second == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    int result = first % second;
    Console.WriteLine($"Не кратно, остаток {result}");
}


