using System.Diagnostics;

namespace OS;

public abstract class ShellBase
{
    protected abstract string Executable { get; }
    
    protected async Task RunCommand(string command)
    {
        var args = $"{command}";
        // var args = $"-Command {command}";
        var startInfo = new ProcessStartInfo(Executable, args)
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            RedirectStandardInput = true
        };

        using var process = Process.Start(startInfo);

        if (process == null)
        {
            throw new InvalidOperationException("Unable to launch shell");
        }

        var output = await process.StandardOutput.ReadToEndAsync();

        Console.WriteLine($"Output: {output}");

        await process.WaitForExitAsync();
    }
}