Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

string[] strings = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку {0}: ", i + 1);
    strings[i] = Console.ReadLine();
}

string[] filteredStrings = FilterStrings(strings);

Console.WriteLine("Результат:");

for (int i = 0; i < filteredStrings.Length; i++)
{
    Console.WriteLine(filteredStrings[i]);
}

Console.ReadKey();


string[] FilterStrings(string[] strings)
{
    int count = 0;

    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            count++;
        }
    }

    string[] filteredStrings = new string[count];

    int index = 0;

    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            filteredStrings[index] = strings[i];
            index++;
        }
    }

    return filteredStrings;
}