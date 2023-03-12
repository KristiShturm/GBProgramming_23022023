/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.Write("Напишите номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 1:
         Console.Write("x>0, y>o");
         break;
    case 2:
         Console.Write("x<0, y>o");
         break;
    case 3:
         Console.Write("x<0, y<o");
         break;
    case 4:
         Console.Write("x>0, y<o");
         break;
    default: 
         Console.Write("Нет такой четверти!");
         break;
}

