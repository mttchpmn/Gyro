using System.Runtime.InteropServices;

namespace OS;

public class ShellFactory
{
    public static IShell GetShell()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return new PowerShell();
        
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            throw new NotSupportedException("Mac OS not yet supported");
        
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            throw new NotSupportedException("Linux not yet supported");

        throw new NotSupportedException("Platform not supported");
    }
}