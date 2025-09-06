using AbstractFactory;

namespace AbstractFactory;

public class AdvancedComputerPartsFactory : IComputerPartsFactory
{
    public ICPU CreateCPU()
    {
        return new AdvancedCPU();
    }

    public IKeyboard CreateKeyboard()
    {
        return new AdvancedKeyboard();
    }

    public IMonitor CreateMonitor()
    {
        return new AdvancedMonitor();
    }
}