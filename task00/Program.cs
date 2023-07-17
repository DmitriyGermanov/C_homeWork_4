// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе из функции выдаем это число
{
    Console.Write($"{message} ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string UpString(int x) //Преобразуем число в надстрочный текст. Аргумент - целое число
{
    string[] superscript = { "\u2070", "\u00b9", "\u00b2", "\u00b3", "\u2074", "\u2075", "\u2076", "\u2077", "\u2078", "\u2079" };
    string ans = "";
    int a = 0;
    while (x > 0)
    {
        a = x % 10;
        x = x / 10;
        ans = superscript[a] + ans;
    }
    return ans;
}

int Degree(int a, int b) //Возводим число в степень. Аргумент 1 - число, Аргумент 2 - степень числа
{
    int x = 0;
    if (b == 0)
        x = 0;
    else
    {
        if (b == 1)
            x = a;
        else
        {
            for (int i = 1; i < b; i++)
                x += a * a;
        }
    }
    return x;
}


int a = GetNumber("Введите число:");
int b = GetNumber("Введите степень числа:");



Console.WriteLine($"{a}{UpString(b)} = {Degree(a, b)}");
