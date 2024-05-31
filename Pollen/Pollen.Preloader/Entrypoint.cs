using Pollen.Preloader;
using Pollen.Preloader.Managers;
using Pollen.Preloader.Utilities;

namespace Doorstop;

public class Entrypoint
{
    public static void Start()
    {
        if (EnvVars.DoorstopInitialized !=
            "TRUE") // DoorstopInitialized will always be set to 'TRUE' when ran via doorstop
        {
            FileLogger.WriteCrucialError($"Failed to load pollen, loader was not initialized through doorstop: {EnvVars.DoorstopInitialized}");
            return;
        }

        DirectoryManager.Initialize();
        
    }
}