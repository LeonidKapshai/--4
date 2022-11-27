Console.WriteLine("Введите массив из 8 элементов");
int [] array = new int[8];

// var newArray = FillArray(array);
// PrintArray(newArray);

// int[] FillArray(int[] arr)
// {
//     var result = new int[arr.Length];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         result[i] = new Random().Next(0,100);
//     }
//     return result;
// }

Console.WriteLine("Введите 1 элемент массива");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 элемент массива");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 элемент массива");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 4 элемент массива");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 5 элемент массива");
array[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 6 элемент массива");
array[5] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 7 элемент массива");
array[6] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 8 элемент массива");
array[7] = Convert.ToInt32(Console.ReadLine());

PrintArray(array);

void PrintArray(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}