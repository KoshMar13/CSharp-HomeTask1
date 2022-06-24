// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Insert first number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert third number: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

int[] numbers = {numb1, numb2, numb3};
int maxVal = numbers.Max();
Console.WriteLine($"Maximum = {maxVal}");
