// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Напишите целое число: ");
int N = int.Parse(Console.ReadLine());
 
int count = 0;
while (count < N-1)
{
    count = count + 2;
    Console.WriteLine(count);
}
