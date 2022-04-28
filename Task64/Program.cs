/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 7"
*/

void PrintPositiveIntegers(int numberN, int numberM)
{
    if (numberN <= numberM)
    {
        Console.WriteLine($"Натуральные числа в промежутке от {numberN} до {numberM}:");
        Console.Write(numberN);
        FillPositiveIntegers(numberN, numberM);
    }
    else
    {
        Console.WriteLine("Число N должно быть меньше числа M!");
    }
}

void FillPositiveIntegers(int numberN, int numberM)
{
    while (numberN < numberM)
    {
        numberN++;
        Console.Write($", {numberN} ");
    }
}

Console.Write("Введите число N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------");
PrintPositiveIntegers(userNumberN, userNumberM);
