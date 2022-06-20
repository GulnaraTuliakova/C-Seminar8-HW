// Найти произведение двух матриц
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
            Console.Write($"{printArray[m, n]} ");

        }
        Console.WriteLine();
    }
}

Console.WriteLine("Выведем на экран два массива размером m x n, заполненные целыми числами и их произведение.");
Console.WriteLine("Bведите количество строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Bведите количество столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Получившийся первый массив: ");
PrintArray(matrix);
Console.WriteLine();

int[,] matrix2 = new int[m, n];
FillArray(matrix2);
Console.WriteLine("Получившийся второй массив: ");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов: ");
int[,] multip = new int[m, n];

for (int raw = 0; raw < multip.GetLength(0); raw++)
{
    for (int column = 0; column < multip.GetLength(1); column++)
    {
        multip[raw, column] = matrix[raw, column] * matrix2[raw, column];
        Console.Write($"{multip[raw, column]} ");

    }
    Console.WriteLine();
}