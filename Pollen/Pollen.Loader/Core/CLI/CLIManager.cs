using System.Runtime.InteropServices;

namespace Pollen.Loader.Core.CLI;

public class CLIManager
{
    [DllImport("kernel32")]
    static extern bool AllocConsole();
    
    public CLIManager()
    {
        if (!AllocConsole()) return;
        
    }
}