namespace OS;

public interface IShell
{
    Task Run(string command);
}

public record ShellCommandOutput(string StdOut, string StdErr, bool WasSuccessful);