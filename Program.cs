// Вводим исходный массив строк с клавиатуры
Console.Write("Введите элементы массива, разделяя их пробелами: ");
string[] input = Console.ReadLine().Split(' ');

// Создаем новый массив, содержащий только строки длиной меньше или равной 3 символам
string[] output = new string[input.Length];
int outputIndex = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[outputIndex] = input[i];
        outputIndex++;
    }
}
Array.Resize(ref output, outputIndex);

// Выводим результат на экран
Console.WriteLine("Массив строк, длина которых меньше или равна 3 символам:");
for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine(output[i]);
}

Console.ReadLine();
