/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
    m = 3, n = 3 -> A(m,n) = 61
-----------------------------------------
Функция Аккермана:
          n + 1                  m = 0
A(m, n) = A(m - 1, 1)            m > 0, n = 0
          A(m - 1, A(m, n - 1)), m > 0, n > 0   
*/

int calculatingAckermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if (numberN == 0)
    {
        return calculatingAckermanFunction(numberM - 1, 1);
    }
    return calculatingAckermanFunction(numberM - 1, calculatingAckermanFunction(numberM, numberN - 1));
}

void CheckingUserNumbers(int numberM, int numberN)
{
    if ((numberM >= 0) && (numberN >= 0))
    {
        Console.Write("Результат вычисления функции Аккермана = ");
        Console.WriteLine(calculatingAckermanFunction(numberM, numberN));
    }
    else
    {
        Console.WriteLine("Числа m, n должны быть больше или равны нулю!");
    }
}

Console.Write("Введите число m: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------");
CheckingUserNumbers(userNumberM, userNumberN);
