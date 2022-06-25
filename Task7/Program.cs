// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Трёхзначное число: ");
// string numb = Console.ReadLine();
// if(numb.Length != 3)
// {
//     Console.Write("Введено некорреткное число. Повторите ввод: ");
//     string numb1 = Console.ReadLine();
//     numb = numb1;
// }
// Console.Write(numb[2]);

int numb = Convert.ToInt32(Console.ReadLine());
int decades = (int)(numb/10);
double answer = numb % decades;
Console.WriteLine(answer);
