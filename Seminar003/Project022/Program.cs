/*Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

System.Console.Write("Напишите число: ");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
        System.Console.WriteLine(i * i);
        break;
    }
    System.Console.Write(i * i + ", ");   
}




