// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

// void cube(int x)
// {
//     int count = 1;
//     while ( count <= x)
//     {
//         Console.Write($"{(Math.Pow(count, 3))}, ");
//         count++;
//     }
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{a} -> ");
// cube(a);


// или

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Console.Write($"{N} -> ");
for(int i = 1; i <= N; i++)  // (от i ; до i = N ; и какой шаг(в данном случае +1))
{
     Console.Write($"{i*i*i}, ");
}

