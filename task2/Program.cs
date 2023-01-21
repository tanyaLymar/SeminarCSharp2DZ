// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");


if (number1 == number2*number2) Console.WriteLine("Первое число является квадратом второго");
else if (number2==number1*number1) Console.WriteLine("Второе число является квадратом первого");
else Console.WriteLine("Ни первое, ни второе число не являются квадратами друг друга");