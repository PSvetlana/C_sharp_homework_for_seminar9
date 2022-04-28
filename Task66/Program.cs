/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void PrintSumPositiveIntegers(int numberN, int numberM)
{
    if (numberN <= numberM)
    {
        Console.Write($"Сумма натуральных чисел в промежутке от {numberN} до {numberM} = ");
        Console.WriteLine(FindSumPositiveIntegers(numberN, numberM));
    }
    else
    {
        Console.WriteLine("Число N должно быть меньше или равно числу M!");
    }
}

int FindSumPositiveIntegers(int numberN, int numberM)
{
    int sum = numberN;
    if (numberN < numberM)
    {
        sum += FindSumPositiveIntegers(numberN + 1, numberM);
    }
    return sum;
}

Console.Write("Введите число N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------");
PrintSumPositiveIntegers(userNumberN, userNumberM);