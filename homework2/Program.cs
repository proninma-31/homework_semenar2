// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int Writetext(string message)
{
  Console.WriteLine(message);
  int mynumber = Convert.ToInt32(Console.ReadLine());
  return mynumber;
}

int BigBang()
{
int number = Writetext("Введите трехзначное число");
int numberA = number % 100;
int res = numberA / 10;
return res;
}

int result = BigBang();
Console.WriteLine($" Вторая цифра {result}");
//===================================================================================================
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



//==========================================================================================

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
int Writetext(string message)
{
  Console.WriteLine(message);
  int mynumber = Convert.ToInt32(Console.ReadLine());
  return mynumber;
}

int vvod = Writetext(Введите число)
int arr.length = [7]
index = 0;
counce = 0
int array = [Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье];

while(index == arr.length)
index++
if 


