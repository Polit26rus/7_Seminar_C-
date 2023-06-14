// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int Prompt(string text){
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double[,] GetArray2d()
// {
//     int m = Prompt("Введите значение строк: ");
//     int n = Prompt("Введите значение столбцов: ");

//     double[,] array = new double[m, n];
//     for(int i = 0;i < m;i++){
//         for(int j = 0;j < n;j++){
//             temp = new Random().GetType();
//             array[i, j] = new Random().NextDouble()*(10 - (-10)) - 10 || array[i, j] = new Random().Next(-10,10);
//         }
        
//     }
    
//     return array;
// }
// void PrintArray2d(double [,] array2d)
// {
//     for(int i = 0;i < array2d.GetLength(0);i++){
//         for(int j = 0;j < array2d.GetLength(1);j++){
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// double[,] array2d = GetArray2d();
// PrintArray2d(array2d);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

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
//             array[i, j] = new Random().Next(-10, 10);
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

// string ArrayElement(int[,] array,int row, int column){
//     if(row < array.GetLength(0) && column < array.GetLength(1)){
//         return $"[{row},{column}] элемент = {array[row,column]}";
//     }
//     else return "Такого элемента нет";
// }


// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);
// int r = Prompt("Какая строка ");
// int k = Prompt("Какой столбец ");
// Console.WriteLine(ArrayElement(array2d, r , k));






// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// void AverageOfArrayColumns(int [, ] array)
// {
//     for(int i = 0;i < array.GetLength(1);i++){
//         int count = 0;
//         for(int j = 0;j < array.GetLength(0);j++){
//             count += array[j,i];
//         }
//         count /= array.GetLength(0);
//         Console.Write(count + " ");
//     }
// }


// int[,] array2d = GetArray2d();
// PrintArray2d(array2d);
// Console.WriteLine();
// AverageOfArrayColumns(array2d);