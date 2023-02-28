// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Напишите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Напишите второе число: ");
int b = int.Parse(Console.ReadLine());

int max = 0;

if (a > b) 
{
    max = a;
    Console.WriteLine($"Больше число {max}");
}
else 
{
    max = b;
    Console.WriteLine($"Больше число {max}");
}
