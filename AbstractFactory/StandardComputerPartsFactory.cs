namespace AbstractFactory;

public class StandardComputerPartsFactory : IComputerPartsFactory
{
    public ICPU CreateCPU()
    {
        return new StandardCPU();
    }

    public IKeyboard CreateKeyboard()
    {
        return new StandardKeyboard();
    }

    public IMonitor CreateMonitor()
    {
        return new StandardMonitor();
    }
}