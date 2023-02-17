public class MemoryItem
{
    public double Value { get; set; }
    public string Operation { get; set; }
}

public class Memory
{
    private List<MemoryItem> items;

    public Memory()
    {
        items = new List<MemoryItem>();
    }

    public void AddToMemory(double value, string operation)
    {
        items.Add(new MemoryItem { Value = value, Operation = operation });
    }

    public List<MemoryItem> GetMemory()
    {
        return items;
    }

    public void ClearMemory()
    {
        items.Clear();
    }
}
