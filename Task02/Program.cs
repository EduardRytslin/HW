// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 1-е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} — большее, а число {number2} — меньшее");
}
else if (number1 < number2)
{
    Console.WriteLine($"Число {number2} — большее, а число {number1} — меньшее");
}
else
{
    Console.WriteLine("Вы ввели 2 одинаковых числа — они равны");
}