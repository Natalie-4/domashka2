/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Введите трёхзначное число: ");
int NumberDigit3 = Convert.ToInt32(Console.ReadLine());
int NumberDigit2 = NumberDigit3/10;
int TwoDigit = NumberDigit2%10;
Console.WriteLine(TwoDigit);

