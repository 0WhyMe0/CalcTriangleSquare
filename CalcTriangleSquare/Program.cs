using CalcTriangleSquare;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        double square1 = calculator.CalctriangleSquare(10, 20);
        double square2 = calculator.CalctriangleSquare(16, 25, 36);

        double roundeNumberSquare1 = Math.Round(square1, 2);
        double roundeNumberSquare2 = Math.Round(square2, 2);

        Console.WriteLine($"Square1: {roundeNumberSquare1}. Square2: {roundeNumberSquare2}");
    }
}