/* Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/


Console.Write("Напишите число: ");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
        Console.WriteLine(Math.Pow(i, 3));
        break;
    }
    Console.Write(Math.Pow(i, 3) + ", ");   
}