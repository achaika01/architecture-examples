using OCP.After.Application;

namespace OCP.After.Commands;

public class EchoCommand : ICommand
{
    public bool CanHandle(string command)
    {
        return command.Equals("/echo", StringComparison.OrdinalIgnoreCase);
    }

    public void Execute(string arguments)
    {
        Console.WriteLine(arguments);
    }
}
