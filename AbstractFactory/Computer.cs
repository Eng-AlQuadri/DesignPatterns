namespace AbstractFactory;

public class Computer
{
    private readonly IMonitor _monitor;
    private readonly IKeyboard _keyboard;
    private readonly ICPU _cpu;

    public Computer(IComputerPartsFactory factory)
    {
        _monitor = factory.CreateMonitor();
        _keyboard = factory.CreateKeyboard();
        _cpu = factory.CreateCPU();
    }

    public string GetMonitorInfo()
    {
        return _monitor.Display();
    }

    public string GetKeyboardInfo()
    {
        return _keyboard.Display();
    }

    public string GetCPUInfo()
    {
        return _cpu.Display();
    }

    public override string ToString()
    {
        return $"{GetMonitorInfo()} | {GetCPUInfo()} | {GetKeyboardInfo()}";
    }
}