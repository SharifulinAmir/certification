// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


// void ShowNumbers(int M, int N){
//     if (M == N) {
//     Console.Write(M);
//     return;
//     }
//     Console.Write($"{M}, ");
//     ShowNumbers(M + 1, N);
// }
// Console.Write("Введите минимум: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максисум: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(M, N);




// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


// int AckermanFunction (int m, int n){
//     if (m == 0) return n + 1;
//     if (n == 0) return AckermanFunction(m-1, 1);
//     return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
// }

// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(AckermanFunction(m, n));






// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


void Recursion(int[] array, int start = 0){
    if (start != array.Length) {
        Recursion(array, start + 1);
        Console.Write($"{array[start]}, ");
    }
}
var array = new int[]{1, 2, 5, 0, 10, 34};
Recursion(array);
