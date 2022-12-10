int[,] array = GetArray(3, 3, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintMin(PrintSum(array));


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

int[] PrintSum(int[,] array){
    int[] sum_array = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){    
            sum_array[i] += array[i,j];
        }
    }
    return sum_array;
}

void PrintMin(int[] array){
    int Min = array[0];
    int Pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < Min){
                Pos = i;
        }  
    }
    Console.Write($"Cтрока с наименьшой суммой элементов это: {Pos} строка");
}


