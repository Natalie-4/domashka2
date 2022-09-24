/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
string? chislo = Console.ReadLine();
int dlina = chislo.Length;
int number = Convert.ToInt32(chislo);

if (number<100)
{
  Console.WriteLine("Третьей цифры нет");  
}
else 
{
for (int count = 0; count < dlina - 3; count++)
{
  number = number/10;
}
int digit3 = number%10;
Console.WriteLine(digit3);
}
