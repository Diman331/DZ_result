// Создание и заполнение исходного массива строк
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
string[] inputArr = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    inputArr[i] = Console.ReadLine()!;
}

// Создание нового массива строк
string[] outputArr = new string[n];
int k = 0;

// Проверка каждой строки из исходного массива и добавление ее в новый массив, если длина <= 3 символов
for (int i = 0; i < n; i++)
{
    if (inputArr[i].Length <= 3)
    {
        outputArr[k] = inputArr[i];
        k++;
    }
}

// Вывод результата
Console.WriteLine("Результат:");
for (int i = 0; i < k; i++)
{
    Console.WriteLine(outputArr[i]);
}