// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Input(string abc, int lenght) // Записываем массив из строки по заданной длине
{
    int[] numbers = new int[lenght];
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(',');
    for (int i = 0; i < numbers.Length; ++i)
        numbers[i] = int.Parse(input[i]);

    return numbers;
}

int GetNumber(string message) //Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе из функции выдаем это число
{
    Console.Write($"{message} ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintMass(int[] a) //Печатаем массив
{
    for (int i = 0; i < a.Length; i++)
    {
        if (i == a.Length - 1)
            Console.Write($"{a[i]}");
        else
            Console.Write($"{a[i]}, ");
    }
}
int a = GetNumber("Введите длину массива:");
int[] b = Input("Введите числа массива через запятую в соответствие с заданой длиной:", a);
PrintMass(b);