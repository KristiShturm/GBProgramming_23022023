// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).

Console.Write("Напишите целое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Число чётное");
}
else
{
    Console.WriteLine($"Число нечётное");
}
