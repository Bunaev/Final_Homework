Console.Clear();

int length = ImputNumber("Введите размер исходного массива", "Введено неверное значение");
int maxSim = ImputNumber("Введите максимальное число символов в элемете результирующего массива", "Введено неверное значение");
string[] array = GetArray(length);

Console.Write("Исходный массив: ");
Console.WriteLine($"[{String.Join(", ", array)}]");

int lengthResult = GetSizeArray(array, maxSim);
string[] arrayResult = GetNewArray(lengthResult, array, maxSim);

Console.Write("Результирующий массив: ");
Console.WriteLine($"[{String.Join(", ", arrayResult)}]");

// Описание метода ImputNumber для ввода целых положительных чисел больше единицы

int ImputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 1)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Описание метода GetArray  - пользователь вводит элементы массива колличеством равным length

string[] GetArray(int index)
{
    string[] result = new string[index];
    for (int i = 0; i < index; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент массива");
        result[i] = Console.ReadLine() ?? "";
    }
    return result;
}

// Описание метода GetSizeArray - определяет длину будущего массива

int GetSizeArray(string[] array, int max)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= max)
        {
            k++;
        }
    }
    return k;
}

// Описание метода GetNewArray - заполняет новый массив элементами, если они соответствуют условиям

string[] GetNewArray(int length, string[] array, int max)
{
    string[] result = new string[length];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i].Length <= max)
            {
                result[k] = array[i];
                k++;
            }
    }
    return result;
}