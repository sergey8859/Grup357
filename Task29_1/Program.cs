// Напишите программу, которая задаёт массив из 8 элементов и выводит 
// их на экран. Данные вводятся с консоли пользователем.


Console.Write("Введите количество элементов массива:\t");
int array = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[array];

for (int i = 0; i <= (nums.Length - 1); i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", nums)}]");
