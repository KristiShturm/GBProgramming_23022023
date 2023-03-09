// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

//Случайное число на отрезке [10;99]
int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число: {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
   Console.WriteLine(secondDigit); 
}



