/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
Console.Write("Напишите координату X1: ");
double X1 = double.Parse(Console.ReadLine());

Console.Write("Напишите координату Y1: ");
double Y1 = double.Parse(Console.ReadLine());

Console.Write("Напишите координату X2: ");
double X2 = double.Parse(Console.ReadLine());

Console.Write("Напишите координату Y2: ");
double Y2 = double.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
Console.Write(dist);
