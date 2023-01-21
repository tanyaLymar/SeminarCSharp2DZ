// Найти расстояние между точками в пространстве 2D/3D

 
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            double z1 = 0;
            double z2 = 0;
            double distance2D;
            double distance3D;
            int n = 0;
            bool isTrue = true;

 while(isTrue)
    {
        Console.WriteLine("Если вычисление проводится в двумерном пространстве - нажмите 2, если в трехмерном - нажмите 3");
        n = int.Parse(Console.ReadLine() ?? "0");
     
        switch(n)
            {
                case 2: 
                    Console.WriteLine("Введите координаты двух точек");

                    Console.Write("x1=");
                    x1 = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("x2=");
                    x2 = double.Parse(Console.ReadLine() ?? "0");

                    Console.Write("y1=");
                    y1 = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("y2=");
                    y2 = double.Parse(Console.ReadLine() ?? "0");
                    distance2D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));  
                    Console.WriteLine("Расстояние между двумя точками равно: " + distance2D);
                    isTrue = false;
                    break;
                
                case 3: 
                    Console.WriteLine("Введите координаты двух точек");

                    Console.Write("x1=");
                    x1 = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("x2=");
                    x2 = double.Parse(Console.ReadLine() ?? "0");

                    Console.Write("y1=");
                    y1 = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("y2=");
                    y2 = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("z1=");
                    z1 = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("z2=");
                    z2 = double.Parse(Console.ReadLine() ?? "0");
                    distance3D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                    Console.WriteLine("Расстояние между двумя точками равно: " + distance3D);
                    isTrue = false;
                    break;

                default: 
                    Console.WriteLine("Попробуйте ввести заново.");
                    break;
            }
    }   

            