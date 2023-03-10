/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Напишите число: ");
int number = int.Parse(Console.ReadLine());

if(number < 0)
{
    number = number * (-1);
}
if(number <= 99)
{
    Console.Write("Третьей цифры нет!");
}
if(number > 99)
{
    while(number >= 999)
    {
        number /= 10;
    }
int result = number % 10;
Console.Write($"{result}");
}

