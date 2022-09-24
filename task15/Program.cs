/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Введите номер дня недели");
int NomerDnyaNedeli = Convert.ToInt32(Console.ReadLine());
if (NomerDnyaNedeli>0||NomerDnyaNedeli<8)
{
    switch (NomerDnyaNedeli)
    {
        case 7:
        Console.WriteLine("Day off");
        break;

        case 6:
        Console.WriteLine("Day off");
        break;

        case 5:
        Console.WriteLine("Working day");
        break;

        case 4:
        Console.WriteLine("Working day");
        break;

        case 3:
        Console.WriteLine("Working day");
        break;

        case 2:
        Console.WriteLine("Working day");
        break;

        case 1:
        Console.WriteLine("Working day");
        break;
    }
}
else 
{
  
        Console.WriteLine("Введите заново");
}