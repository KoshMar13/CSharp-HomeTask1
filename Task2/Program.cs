// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Insert first number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if (numb1 > numb2)
{
    Console.WriteLine($"max = {numb1}");
}
else if (numb1 < numb2)
{
    Console.WriteLine($"max = {numb2}");
}
else
{
    Console.WriteLine($"{numb1} and {numb2} are equal");
}