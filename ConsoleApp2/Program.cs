class Program
{
    static void Main(string[] args)
    {
        RealCalculator calculator = new RealCalculator();
        double result = calculator.Add(2, 3);
        Console.WriteLine("The result of the calculation is: " + result);
    }
}