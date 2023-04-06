void InputMatrix(int[,,] matrix)
{
    int[] generated = new int[100]; 
    generated[0] = 1;  
    for (int x = 0; x < matrix.GetLength(0); ++x)
        for (int y = 0; y < matrix.GetLength(1); ++y)
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                while (generated[matrix[x, y, z]] == 1)                          
                    matrix[x, y, z] = new Random().Next(10, generated.Length);   
                generated[matrix[x, y, z]] = 1;                                  
            }                                                                    
}

void PrintMatrix(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
                Console.Write($"{matrix[x, y, z]}({x},{y},{z})\t");
            Console.WriteLine();
        }
}

int x = 3, y = 3, z = 3;
int[,,] matrix = new int[x, y, z];
InputMatrix(matrix);
Console.WriteLine("Получена матрица:");
PrintMatrix(matrix);