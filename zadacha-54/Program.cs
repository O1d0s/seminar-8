int[,] array = GetArray(3, 3, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array));


int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int MinPos = j;
            for (int k = j+1; k < array.GetLength(0); k++)        
            {
                if(array[i,k] < array[i,MinPos]){
                    MinPos = k;
                }     
            }
        int temp = array[i,j];
        array[i,j] = array[i,MinPos];
        array[i,MinPos] = temp;
        }
    }
    return array;
}


