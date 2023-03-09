/*Напишите программу, которая принимает на вход два числа и 
проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
Console.Write("Напишите первое число: ");
int first = int.Parse(Console.ReadLine());

Console.Write("Напишите второе число: ");
int second = int.Parse(Console.ReadLine());

/*if(first > second)
{
    if(second*second == first)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
else
{
    if(first*first == second)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
*/
if(first > second)
{
    second *= second;
}
else
{
    first *= first;
}
if(first == second)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}