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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int k = 0; k < product.GetLength(0); k++)
        for (int l = 0; l < product.GetLength(1); l++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                product[k, l] += matrix1[k, j] * matrix2[j, l];
    return product;
}
//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

Console.Clear();
int m = 5, n = 3, l = 4;
int[,] matrix1 = new int[n, l];
int[,] matrix2 = new int[l, m];
InputMatrix(matrix1);
InputMatrix(matrix2);
Console.WriteLine("Матрица:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица II:");
PrintMatrix(matrix2);
Console.WriteLine($"Матрица: Произведение");
PrintMatrix(MatrixProduct(matrix1, matrix2));