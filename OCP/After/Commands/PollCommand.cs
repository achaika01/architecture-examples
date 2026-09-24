using OCP.After.Application;

namespace OCP.After.Commands;

// An extension: neither the command loop nor the existing commands need modification.
public class PollCommand : ICommand
{
    public bool CanHandle(string command)
    {
        return command.Equals("/poll", StringComparison.OrdinalIgnoreCase);
    }

    public void Execute(string arguments)
    {
        var parts = arguments.Split('|', StringSplitOptions.TrimEntries);
        if (parts.Length < 3 || parts.Any(string.IsNullOrWhiteSpace))
        {
            Console.WriteLine("Usage: /poll question | option | option");
            return;
        }

        Console.WriteLine($"Poll: {parts[0]}");
        for (var index = 1; index < parts.Length; index++)
        {
            Console.WriteLine($"{index}. {parts[index]}");
        }
    }
}
