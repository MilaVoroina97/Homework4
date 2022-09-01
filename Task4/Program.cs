// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

// int arraySize = 123;
// int[] array = new int[arraySize];
// for (int i = 0; i < arraySize; ++i) {
//     array[i] = new Random().Next(-100, 100);
// }
// int count = 0;
// for (int i = 0; i < arraySize - 1; ++i) {
//     Console.Write($"{array[i]}, ");
// }
// Console.WriteLine(array[arraySize - 1]);
// for (int i = 0; i < arraySize; ++i) {
//     if (array[i] >= 10 && array[i] <= 99) {
//         count++;
//     }
// }
// Console.WriteLine($"Количество элементов в промежутке [10, 99] - {count}");

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; ++i) {
    array[i] = new Random().Next(1, 10);
}
Console.Write("[");
for (int i = 0; i < N - 1; ++i) {
    Console.Write(array[i] + " ");
}
Console.WriteLine(array[N - 1] + "]");
int[] result = new int[N / 2 + N % 2];
for(int i = 0; i < array.Length / 2; ++i) {
    result[i] = array[i] * array[array.Length - 1 - i];
}
if(array.Length % 2 == 1){
    result[array.Length / 2] = array[array.Length / 2];
}
for (int i = 0; i < result.Length - 1; ++i) {
    Console.Write(result[i] + " ");
}
Console.WriteLine(result[result.Length - 1]);
