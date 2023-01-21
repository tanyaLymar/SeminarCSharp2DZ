// Задать номер четверти, показать диапазоны для возможных координат
bool isTrue = true;

while(isTrue)
{
    Console.WriteLine("Введите номер координатной четверти");
    int n = int.Parse(Console.ReadLine()?? "0");

    switch(n)
        {
            case 1:
                Console.WriteLine("Диапазон возможных значений: x (0; PositiveInfinity), y (0; PositiveInfinity");
                isTrue = false;
                break;

            case 2:
                Console.WriteLine("Диапазон возможных значений: x (0; NegativeInfinity), y (0; PositiveInfinity)");
                isTrue = false;
                break;

            case 3:
                Console.WriteLine("Диапазон возможных значений: x (0; NegativeInfinity), y (0; NegativeInfinity)");
                 isTrue = false;
                 break;

            case 4:
                Console.WriteLine("Диапазон возможных значений: x (0; PositiveInfinity), y (0; NegativeInfinity)");
                 isTrue = false;
                break;

            default:
                Console.WriteLine("Такой четверти не существует. Попробуйте еще раз.");
                break;
        }
}