//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
               array[i, j, k] = new Random().Next(10, 100); 
              
            }
           
        }
    }
}
void PrintArray(int[,,] printArray)
{
    for (int m = 0; m < printArray.GetLength(0); m++)
    {
        for (int n = 0; n < printArray.GetLength(1); n++)
        {
             for (int p = 0; p < printArray.GetLength(2); p++)
             {
                 Console.Write($"Number({m},{n},{p}):{printArray[m, n, p]}   ");
                  //Console.WriteLine();
             }
           

        }
        Console.WriteLine();
    }
}

Console.WriteLine("Выведем на экран трехмерный массив, заполненные двузначными числами");
Console.WriteLine("Bведите количество строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Bведите количество столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Bведите количество столбцов p: ");
int p = int.Parse(Console.ReadLine() ?? "0");
int[,,] matrix = new int[m, n, p];
FillArray(matrix);
Console.WriteLine("Получившийся массив: ");
PrintArray(matrix);
Console.WriteLine();
/*
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
}*/