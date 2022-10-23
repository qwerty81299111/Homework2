//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. 
 //Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 100 && num < 1000) 
{
    int firstNumber = num % 100;
    int secondNumber = firstNumber / 10;
    Console.WriteLine(secondNumber);
}
else Console.Write("число не корректное"); 


 