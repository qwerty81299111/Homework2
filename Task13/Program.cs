//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int ThirdNumber(int number)
{
    while (number > 1000)
    {
        number = number /10;
    }
    return number % 10 ;
}

Console.WriteLine("Введите число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num < 100) Console.WriteLine("третьей цифры нет");
else Console.WriteLine($"третья цифра числа  = {ThirdNumber(num)}");