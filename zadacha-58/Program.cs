int[,] array1 = GetArray(2, 2, 0, 10);
int[,] array2 = GetArray(2, 2, 0, 10);
Console.WriteLine("Первый массив:");
PrintArray(array1);
Console.WriteLine("Второй массив:");
PrintArray(array2);
Console.WriteLine("Умноженный массив:");
PrintArray(ProizdArray(array1,array2));

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

int[,] ProizdArray(int[,] arr1,int[,] arr2){
    int[,] proiz_mas = new int[arr1.GetLength(0),arr1.GetLength(1)];
    for(int i = 0; i < arr1.GetLength(0); i++){
        for(int j = 0; j < arr1.GetLength(1); j++){
            for (int k = 0; k < arr1.GetLength(0); k++)
            {
                proiz_mas[i,j] += arr1[i,k]*arr2[k,j]; 
            }
        }
    }
    return proiz_mas;        
}