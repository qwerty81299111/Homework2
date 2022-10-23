// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

//Console.Write("введите число: ");
//int a = Convert.ToInt32(Console.ReadLine());

//if(a == 1)Console.Write("понедельник");
//if(a == 2)Console.Write("вторник");
//if(a == 3)Console.Write("среда");
//if(a == 4)Console.Write("четверг");
//if(a == 5)Console.Write("пятница");
//if(a == 6)Console.Write("суббота");
//if(a == 7)Console.Write("воскресенье");
//if(a == 6)Console.Write(" день является выходным");
//if(a == 7)Console.Write(" день является выходным");
//if(a == 1)Console.Write(" будний день");
//if(a == 2)Console.Write(" будний день");
//if(a == 3)Console.Write(" будний день");
//if(a == 4)Console.Write(" будний день");
//if(a == 5)Console.Write(" будний день");


bool week(int num)
{
    return num == 6 || num == 7;
}

Console.Write("введите номер недели");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 7 || num < 1)
{
    Console.Write("нет, день не выходной");
}
else Console.Write(week(num) ? "да, день выходной": "нет, день будний");