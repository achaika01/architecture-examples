using OCP.After.Application;
using OCP.After.Commands;

Console.WriteLine("BEFORE — /exit continues to the refactored version");
new OCP.Before.CommandLoop().Run();

Console.WriteLine("AFTER — /exit finishes the program");
// A new command changes registration here; CommandLoop stays unchanged.
new CommandLoop(new ICommand[]
{
    new EchoCommand(),
    new TimeCommand(),
    new PollCommand()
}).Run();
