void InputMatrix(int[,] matrix)
{
    int y = 0, x = 0, count = 1;
        while (count <= matrix.Length)                                  
        {
            matrix[y, x] = count;                                       
            count++;                                                    
            if (y <= x + 1 && y + x < matrix.GetLength(1) - 1) x++;     
            else if (y < x && y + x >= matrix.GetLength(0) - 1) y++;    
            else if (y >= x && y + x > matrix.GetLength(1) - 1) x--;    
            else y--;                                                   
        }
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

int m = 4, n = 4;
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Получена матрица:");
PrintMatrix(matrix);