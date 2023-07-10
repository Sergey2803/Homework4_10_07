/*
Задача 25: 
Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
int A = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int B = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
int DegNumber = GetDegNumber(A);
Console.WriteLine($"{A}, {B} -> {DegNumber}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
            return UserNumber;

        Console.WriteLine(errorMessage);
    }
}

int GetDegNumber(int count)
{
    DegNumber = 1;
    count = 1;
    while (count <= B)
    {
        DegNumber *= A;
        count++;
    }

    return DegNumber;
}