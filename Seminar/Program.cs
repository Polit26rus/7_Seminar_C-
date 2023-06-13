// 46:Задайте двумерный массив размеров МхН заполненный 
// случайныйми целыми числами

// int Prompt(string text){
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetArray2d()
// {
//     int m = Prompt("Введите значение строк: ");
//     int n = Prompt("Введите значение столбцов: ");
//     int[,] array = new int[m, n];
//     for(int i = 0;i < m;i++){
//         for(int j = 0;j < n;j++){
//             array[i, j] = new Random().Next(-100, 101);
//         }
        
//     }
    
//     return array;
// }
// void PrintArray2d(int [,] array2d)
// {
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);

// Задача 48

// int Prompt(string text){
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetArray2d()
// {
//     int m = Prompt("Введите значение строк: ");
//     int n = Prompt("Введите значение столбцов: ");
//     int[,] array = new int[m, n];
//     for(int i = 0;i < m;i++){
//         for(int j = 0;j < n;j++){
//             array[i, j] = i + j;
//         }
        
//     }
    
//     return array;
// }
// void PrintArray2d(int [,] array2d)
// {
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);

// Задача 49:Задайте двумерный массив.Найдите эл у которых оба индекса чётные и 
// замените эти эл на их квадраты

// int Prompt(string text){
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetArray2d()
// {
//     int m = Prompt("Введите значение строк: ");
//     int n = Prompt("Введите значение столбцов: ");
//     int[,] array = new int[m, n];
//     for(int i = 0;i < m;i++){
//         for(int j = 0;j < n;j++){
//             array[i, j] = new Random().Next(0,10);
//         }
        
//     }
    
//     return array;
// }

    
// void PrintArray2d(int [,] array2d)
// {
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeElementByIndex(int [,] array2d){
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             if(i % 2 == 0 && j % 2 == 0){
//                 array2d[i, j] *= array2d[i, j];
//             }
//         }
//     }
//     return array2d;
// }

// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);
// Console.WriteLine();
// PrintArray2d(ChangeElementByIndex(array2d));

// Задача 51:Задайте двумерный массив и найдите сумму эл,
// находящихся на главной диагонали

// int Prompt(string text){
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetArray2d()
// {
//     int m = Prompt("Введите значение строк: ");
//     int n = Prompt("Введите значение столбцов: ");
//     int[,] array = new int[m, n];
//     for(int i = 0;i < m;i++){
//         for(int j = 0;j < n;j++){
//             array[i, j] = new Random().Next(0,10);
//         }
        
//     }
    
//     return array;
// }

    
// void PrintArray2d(int [,] array2d)
// {
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumOfMainDiagonalEl(int [,] array2d){

//     int sum = 0;
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             if(i == j){
//                 sum += array2d[i, j];
//             }
//         }
//     }
//     return sum;
// }

// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);
// Console.WriteLine();
// Console.WriteLine(SumOfMainDiagonalEl(array2d));