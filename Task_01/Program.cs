// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}

string num = Math.Abs(number).ToString();

if (num.Length != 5)
{
    Console.WriteLine("Вы ввели не пятизначное число"); 
}

else if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine($"Число {num} является палиндромом");
}

else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}