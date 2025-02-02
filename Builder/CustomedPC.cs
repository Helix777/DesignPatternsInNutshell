



public class CustomedPC
{
    public string Part1 { get; set; }
    public string Part2 { get; set; }
    public string Part3 { get; set; }

    public void Display()
    {
        Console.WriteLine($"Part1: {Part1}");
        Console.WriteLine($"Part2: {Part2}");
        Console.WriteLine($"Part3: {Part3}");
    }
}