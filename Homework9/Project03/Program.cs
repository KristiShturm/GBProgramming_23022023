/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

(int, int) CheckInput(int M, int N)
{
    M = Math.Abs(M);
    N = Math.Abs(N); 
    return (M, N);
}

int GetAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else
    {
        if ((m > 0) && (n == 0))
        {
            return GetAkkermanFunction(m - 1,1);
        }
        else
        {
            return GetAkkermanFunction(m-1, GetAkkermanFunction(m,n-1));
        }
    }
}

int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");

(M, N) = CheckInput(M, N);

Console.WriteLine($"Результат вычисления функции Аккермана для чисел {M} и {N} = {GetAkkermanFunction(M,N)}");
