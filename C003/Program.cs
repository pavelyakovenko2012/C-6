// Сумма элементов главной диоганали
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++) // строчки: GetLength(1) = m (кол-во строк)
{
for (int j = 0; j < array.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)
{
array[i, j] = new Random().Next(0, 10); //[)
Console.Write(array[i, j] + "\t" );
}
System.Console.WriteLine();
}

int sum = 0;
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (i == j) sum += array[i,j]; //(0,0);(1,1);(2,2);(3,3)
}
}
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");;
