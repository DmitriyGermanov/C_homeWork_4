// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе из функции выдаем это число
{
    Console.Write($"{message} ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int BitwiseAddition(int a) //Функция нахождения поразрадяной суммы числа (аргумент a - число)
{
    int sum = 0;
    for (; a > 0; a /= 10)
        sum = sum + a % 10;
    return sum;
}


int a = GetNumber("Введите число:");

Console.WriteLine($"Сумма цифр в числе = {BitwiseAddition(a)}");