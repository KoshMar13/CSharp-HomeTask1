// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Insert number: ");
int numb = Convert.ToInt32(Console.ReadLine());
int count = 2;

var numbers = new List<int>();
while(count <= numb)
{
    numbers.Add(count);
    count += 2;
}

var answer = string.Join(", ", numbers);
Console.WriteLine(answer);
