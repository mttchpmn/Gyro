namespace OS;

public class PowerShell : ShellBase, IShell
{
    protected override string Executable => "pwsh.exe";

    public async Task Run(string command)
        => await base.RunCommand($"-Command {command}");
}