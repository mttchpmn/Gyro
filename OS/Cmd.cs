namespace OS;

public class Cmd : ShellBase, IShell
{
    protected override string Executable => "cmd.exe";

    public async Task Run(string command)
        => await RunCommand($"/C {command}");
}