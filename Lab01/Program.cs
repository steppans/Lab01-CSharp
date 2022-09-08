// Task 1
Console.WriteLine("Минимальные и максимальные значения для типов CTS:");
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
public class Rectangle
{
    double side1;
    double side2;

    Rectangle(double sideA, double sideB) // => (side1, side2) = (sideA, sideB);
    {
        side1 = sideA;
        side2 = sideB;
    }

    double AreaCalculator()
    {
        return side1 * side2;
    }

    double PerimeterCalculator()
    {
        return 2 * side1 + 2 * side2;
    }

}