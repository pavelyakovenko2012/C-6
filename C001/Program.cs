// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()); // строки
// матрица - двумерный массив
// матрица - табличка, которая состоит из m строк и n столбцов
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()); // столбцы

/// summary - "///" - комментарий перед методом
/// Описывает входные и выходные данные метода

// Комментарий, а summary - только для методов

/// m - кол-во строк, n - кол-во столбцов
/// minRandom, maxRandom
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
//new int[кол-во строк,кол-во столбцов]
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++) // строчки: GetLength(1) = m (кол-во строк)
{
for (int j = 0; j < matrix.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)
{
matrix[i, j] = new Random().Next(minRandom, maxRandom + 1); //[)
}
}
return matrix;
}

int[,] resultMatrix = GetArray(rows, columns, 0, 10);
PrintArray(resultMatrix);
void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
for (int j = 0; j < matrix.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)
{
Console.Write(matrix[i, j] + "\t"); // "\t" - Tab между элементами
}
Console.WriteLine();
}
}