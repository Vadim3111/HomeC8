void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10); // [0, 9]
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int RowMinSum(int[,] matrix)
{
    int min, count=0; int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum[i] = sum[i] + matrix[i, j];
    Console.WriteLine($"[{string.Join(", ", sum)}]");    
    min = sum[0];
    for (int i = 1; i < sum.Length; i++)
        if (sum[i] < min)
            {
                min = sum[i]; count=i;
            }
    return count;
}

Console.Clear();
int m = 5, n = 3;
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {RowMinSum(matrix)}");