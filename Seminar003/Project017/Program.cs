/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());

System.Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if(x == 0 & y == 0 )
{
    Console.Write("Нельзя определить четверь плоскости!");
}
if(x > 0 & y > 0)
{
    Console.Write("I четверь");
}
if(x < 0 & y > 0)
{
    Console.Write("II четверь");
}
if(x < 0 & y < 0)
{
    Console.Write("III четверь");
}
if(x > 0 & y < 0)
{
Console.Write("IV четверь");
}


/*System.Console.WriteLine("Vvedite coordinatu X: ");
int x = int.Parse(Console.ReadLine());
System.Console.WriteLine("Vvedite coordinatu Y: ");
int y = int.Parse(Console.ReadLine());
if (x == 0 || y == 0)
{
    System.Console.WriteLine("Chetvert ne opredelena");
}
if (x > 0 & y > 0)
{
    System.Console.WriteLine("Pervaya chetvert");
}
if (x < 0 & y < 0)
{
    System.Console.WriteLine("Tretya chetvert");
}
if (x > 0 & y < 0)
{
    System.Console.WriteLine("Chetvertaya chetvert");
}
if (x < 0 & y > 0)
{
    System.Console.WriteLine("Vtoraya chetvert");
}
*/
