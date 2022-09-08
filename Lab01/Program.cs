// Task 1

using ClassLibrary01;

Console.WriteLine("Минимальные и максимальные значения для типов CTS:");

// Console.Write(Environment.NewLine);

Console.WriteLine($"byte\t\t{byte.MinValue}\t\t\t\t{byte.MaxValue}");
Console.WriteLine($"sbyte\t\t{sbyte.MinValue}\t\t\t\t{sbyte.MaxValue}");
Console.WriteLine($"short\t\t{short.MinValue}\t\t\t\t{short.MaxValue}");
Console.WriteLine($"ushort\t\t{ushort.MinValue}\t\t\t\t{ushort.MaxValue}");
Console.WriteLine($"int\t\t{int.MinValue}\t\t\t{int.MaxValue}");
Console.WriteLine($"uint\t\t{uint.MinValue}\t\t\t\t{uint.MaxValue}");
Console.WriteLine($"long\t\t{long.MinValue}\t\t{long.MaxValue}");
Console.WriteLine($"ulong\t\t{ulong.MinValue}\t\t\t\t{ulong.MaxValue}");

Console.WriteLine($"float\t\t{float.MinValue}\t\t\t{float.MaxValue}");
Console.WriteLine($"double\t\t{double.MinValue}\t{double.MaxValue}");
Console.WriteLine($"decimal\t\t{decimal.MinValue}\t{decimal.MaxValue}");

Console.WriteLine($"char\t\t[{char.MinValue}]\t\t\t\t{char.MaxValue}");

// Task 2

Console.WriteLine($"{Environment.NewLine}Введите длины сторон прямоугольника:");
double sideA = Convert.ToDouble(Console.ReadLine());
double sideB = Convert.ToDouble(Console.ReadLine());

Rectangle rec = new(sideA, sideB);
Console.WriteLine($"Площадь данного прямоугольника: {rec.Area}");
Console.WriteLine($"Периметр данного прямоугольника: {rec.Perimeter}");

// Task 3

void EnterPointsNumber(out uint PointNum)
{
    Console.WriteLine($"Введите количество вершин многоугольника (от 3 до 5)");

    PointNum = Convert.ToUInt16(Console.ReadLine());
    if (PointNum < 3 || PointNum > 5)
    {
        Console.WriteLine("Введённое значение не соответсвует диапазону!!!");
        EnterPointsNumber(out PointNum);
    }
}

uint PointNum = 0;
Console.WriteLine();
EnterPointsNumber(out PointNum);
Point[] PointArray = new Point[PointNum];
Console.WriteLine($"Введите координаты {PointNum} точек");
for (uint i = 0; i < PointNum; i++)
{
    // Считываем значения x и y, записанные через пробел на одной строке
    var ArrayXY = Console.ReadLine().Split(" ");
    int x = Convert.ToInt32(ArrayXY[0]);
    int y = Convert.ToInt32(ArrayXY[1]);
 
    Point point = new Point(x, y);
    PointArray[i] = point;
}

Figure figure = new Figure(PointArray);
figure.Name = "TestFigure";
// Можно дать возможность пользователю ввести имя фигуры

Console.WriteLine($"Perimeter {figure.Name} is {figure.Perimeter}");