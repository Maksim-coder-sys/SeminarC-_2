//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру обозначающую день недели");
int numberday = Convert.ToInt32(Console.ReadLine());
if (numberday == 6 | numberday == 7)
    {
        Console.WriteLine("Это выходной день");
    }
else if( 1 <= numberday && numberday <= 5)
    {
        Console.WriteLine("Это рабочий день");
    }
else
    {
        Console.WriteLine("Такого дня недели не существует");
    }