using System.Diagnostics;
using Pollen.Preloader.Utilities;

namespace Pollen.Preloader.Managers;

public static class DirectoryManager
{
    public static string
        PollenPath,
        GamePath,
        LibPath,
        CorePath;
    
    public static void Initialize()
    {
        if (EnvVars.DoorstopProcessPath == string.Empty) FileLogger.WriteCrucialError("Doorstop Process Path was not set");

        GamePath = Path.Combine(EnvVars.DoorstopProcessPath, Process.GetCurrentProcess().MainModule!.FileName);
        
        PollenPath = Path.Combine(EnvVars.DoorstopProcessPath, "Pollen");
        if (!Directory.Exists(PollenPath)) FileLogger.WriteCrucialError("Pollen is running in an invalid environment, reinstall."); // This folder should ALWAYS exist.

        CorePath = Path.Combine(PollenPath, "core");
        if (!Directory.Exists(CorePath)) FileLogger.WriteCrucialError("Pollen is running in an invalid environment, reinstall."); // This folder should ALWAYS exist.

        LibPath = Path.Combine(PollenPath, "lib");
        if (!Directory.Exists(LibPath)) Directory.CreateDirectory(LibPath);
    }
}