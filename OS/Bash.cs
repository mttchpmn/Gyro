namespace OS;

public class Bash : ShellBase, IShell
{
    protected override string Executable => "bash.exe";

    public async Task Run(string command)
        => await RunCommand($"-c {command}");
}