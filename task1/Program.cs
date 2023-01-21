// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number == 1|number ==2|number ==3| number ==4|number ==5) Console.WriteLine("Это не выходной день.");
else if(number ==6| number == 7) Console.WriteLine("Это выходной день.");
else Console.WriteLine("Попробуйте еще раз.");
