// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых
// расположен наименьший элемент.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
        }
    }
}
void PrintArray(int[,] printArray)
{
    for (int m = 0; m < printArray.GetLength(0); m++)
    {
        for (int n = 0; n < printArray.GetLength(1); n++)
        {
            Console.Write($"{printArray[m, n]}   ");

        }
        Console.WriteLine();
    }
}

Console.WriteLine("Выведем на экран масив размером m x n, заполненный целыми числами.");
Console.WriteLine("Bведите количество строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Bведите количество столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Получившийся массив: ");
PrintArray(matrix);
Console.WriteLine();

int minNum = matrix[0, 0];
int iMin = 0;
int jMin = 0;
for (int raw = 0; raw < matrix.GetLength(0); raw++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        if (matrix[raw, column] < minNum)
        {
            iMin = raw;
            jMin = column;
            minNum = matrix[raw, column];
        }
    }

}

Console.Write($"Минимальное число: {minNum}");
Console.WriteLine();
Console.WriteLine($"Новый массив с удаленными строкой и столбцом:");

for (int p = 0; p < matrix.GetLength(0); p++)
{
    for (int q = 0; q < matrix.GetLength(1); q++)
    {
        if (p != iMin && q != jMin)

            Console.Write($"{matrix[p, q]}   ");
    }
    Console.WriteLine();

}
