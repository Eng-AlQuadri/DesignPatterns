namespace AbstractFactory;

public interface IComputerPartsFactory
{
    public IMonitor CreateMonitor();
    public IKeyboard CreateKeyboard();
    public ICPU CreateCPU();
}