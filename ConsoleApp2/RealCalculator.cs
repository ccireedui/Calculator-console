public class RealCalculator : Calculator, IAddSubtract
{
    private Memory memory;

    public RealCalculator()
    {
        memory = new Memory();
    }

    public double Add(double num1, double num2)
    {
        Results = num1 + num2;
        memory.AddToMemory(Results, "addition");
        return Results;
    }

    public double Subtract(double num1, double num2)
    {
        Results = num1 - num2;
        memory.AddToMemory(Results, "subtraction");
        return Results;
    }

    public List<MemoryItem> GetMemory()
    {
        return memory.GetMemory();
    }

    public void ClearMemory()
    {
        memory.ClearMemory();
    }
}
