// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке -N до N
// 4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 -> -2, -1, 0, 1, 2

Console.Write("Insert number: ");
int numb = Convert.ToInt32(Console.ReadLine());
int count = (-numb);

var numbers = new List<int>();
while (count <= numb)
{
    numbers.Add(count);
    count += 1;
}

var answer = string.Join(", ", numbers);
Console.WriteLine(answer);
