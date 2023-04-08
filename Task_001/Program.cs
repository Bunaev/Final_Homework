Console.Clear();

int length = ImputNumber("Введите размер исходного массива", "Введено неверное значение");
int maxSim = ImputNumber("Введите максимальное число символов в элемете результирующего массива", "Введено неверное значение");
string[] array = GetArray(length);
Console.Write("Исходный массив: ");
Console.WriteLine($"[{String.Join(", ", array)}]");
int lengthResult = GetSizeArray(array, maxSim);
string[] arrayResult = GetArray2(lengthResult, array, maxSim);
Console.Write("Результирующий массив: ");
Console.WriteLine($"[{String.Join(", ", arrayResult)}]");