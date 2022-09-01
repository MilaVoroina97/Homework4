// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];

for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
Console.WriteLine("Введите число дла проверки его наличия в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int index = -1;
for (int i = 0; i < array.Length; i++)
    {
        if (array [i] == a)
            {
                index = i;
                break;
            }
    }
    if (index == -1) 
    {
        Console.WriteLine("Не нашли.");
    } 
    else 
    {
        Console.WriteLine($"Нашли на позиции {index}");
    }


