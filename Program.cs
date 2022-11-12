//Задача 54

/*int[,] Array = GetArray(5,5,0,10);

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"[{Array[i,j]}]");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] Array)
{   
    {
        for (int i = 0; i < Array.GetLength(0); i++)
            {   
                for(int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int n = j+1; n < Array.GetLength(1); n++)
                    {   
                        if(Array[i,n] > Array[i,j])
                        {   
                            int temp = Array[i,j];
                            Array[i,j] = Array[i,n];
                            Array[i,n] = temp;
                        }                       
                    }
                }
            }
    }
    return Array;
}
PrintArray(Array);
Console.WriteLine();
PrintArray(ChangeArray(Array));*/

//Задача 56  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*int[,] Array = GetArray(3,4,0,10);

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"[{Array[i,j]}]");
        }
        Console.WriteLine();
    }
}

int[] FindSumRow(int[,] Array)
{   
    int[] SumRow = new int[Array.GetLength(0)];
    for(int i = 0; i < Array.GetLength(0); i++ )
    {   
        for(int j = 0; j < Array.GetLength(1); j++)
        {
           SumRow[i] = Array[i,j] + SumRow[i];
        }
    }
    return SumRow;
} 

int[] ArraySumRaw = FindSumRow(Array);

int FindMin(int[] Array)
{   
    int min = Array[0];
    int count = 0;
    for(int i = 0; i<Array.Length; i++)
    {
        if(min>Array[i])
        {
            min = Array[i];
            count = i+1;
        }
    }
    return count;
}

PrintArray(Array);
Console.WriteLine(String.Join(",", ArraySumRaw));
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMin(ArraySumRaw)}");*/

//Задача 58

/*int[,] A = GetArray(2,2,0,5);
int[,] B = GetArray(2,2,0,5);

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"[{Array[i,j]}]");
        }
        Console.WriteLine();
    }
}

PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(MultiArray(A,B));

int[,] MultiArray (int[,] first, int[,] second)
{
    int[,] C = new int[2,2];
    for(int i = 0; i < C.GetLength(0); i++ )
    {
        for(int j = 0; j < C.GetLength(1); j++)
        {
            C[i,j] = A[i,0] * B[0,j] + A[i,1] * B[1,j];
        }
    }
    return C;
}*/

//Задача 60

/*int[,,] GetArray(int m, int n, int p, int MinValue, int MaxValue)
{
    int[,,] result = new int[m,n,p];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; j < p; j++)
            {
                result[i,j,k] = new Random().Next(MinValue, MaxValue+1);
            }
        }
    }
    return result;
}

int[,,] Array = GetArray(2,2,2,10,99);

void PrintArray(int[,,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            for(int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i,j,k]}({i},{j},{k})");
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

PrintArray(Array);*/

//Задача из семинара

int[,] Array = GetArray(5,5,0,10);

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++ )
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"[{Array[i,j]}]");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] Array)
{   
    {
        for (int j = 0; j < Array.GetLength(0); j++)
            {   
                for(int i = 0; i < Array.GetLength(1); i++)
                {
                    for (int n = i+1; n < Array.GetLength(1); n++)
                    {   
                        if(Array[n,j] > Array[i,j])
                        {   
                            int temp = Array[i,j];
                            Array[i,j] = Array[n,j];
                            Array[n,j] = temp;
                        }                       
                    }
                }
            }
    }
    return Array;
}
PrintArray(Array);
Console.WriteLine();
PrintArray(ChangeArray(Array));







