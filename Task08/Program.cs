// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 3)
{
    int count = 2;
    while (count < number)
    {
        Console.Write($"{count} ");
        count += 2;
    } 
}
else if (number <= -3)
{
    int count = 0;
    while (count > number)
    {
        Console.Write($"{count} ");
        count -= 2;
    }

}
else
{
    Console.WriteLine($"Чётных чисел на промежутке от 1 до {number} не найдено");
}