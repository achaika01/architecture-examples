using OCP.After.Application;

namespace OCP.After.Commands;

public class TimeCommand : ICommand
{
    public bool CanHandle(string command)
    {
        return command.Equals("/time", StringComparison.OrdinalIgnoreCase);
    }

    public void Execute(string arguments)
    {
        Console.WriteLine($"UTC: {DateTimeOffset.UtcNow:HH:mm:ss}");
    }
}
