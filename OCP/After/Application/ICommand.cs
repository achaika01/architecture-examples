namespace OCP.After.Application;

public interface ICommand
{
    bool CanHandle(string command);
    void Execute(string arguments);
}
