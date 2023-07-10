/*
Задача 27: 
Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
int A = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int SumNumber = GetSumNumber(A);
Console.WriteLine($"{A} -> {SumNumber}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        else Console.WriteLine(errorMessage);
    }
}

int GetSumNumber(int number)
{
    int sum = 0;
    int num = 0;
    while (number > 0)
    {
        num = number % 10;
        sum += num;
        number = number / 10;
    }
    return sum;
}
