namespace AbstractFactory;

public class Program
{
    public static void Main(string[] args)
    {
        Computer computer = new Computer(new StandardComputerPartsFactory());

        Console.WriteLine($"Standard Computer: {computer}");

        Computer computer1 = new Computer(new AdvancedComputerPartsFactory());

        Console.WriteLine($"Advanced Computer: {computer1}");
    }
}
