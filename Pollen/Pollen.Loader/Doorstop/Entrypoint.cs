using System.Globalization;
using Pollen.Loader.Doorstop;

namespace Doorstop;

public class Entrypoint
{
    // Main entry point for UnityDoorstop
    public static void Main()
    {
        string errorLog = $"pollen_error_{DateTime.Now.ToString(CultureInfo.InvariantCulture)}.log";

        if (EnvVars.DoorstopInitialized ==
            string.Empty) // DoorstopInitialized will always be set to 'TRUE' when ran via doorstop
        {
            File.WriteAllText(errorLog, $"Failed to load pollen, loader was not initialized through doorstop: {EnvVars.DoorstopInitialized}");
            return;
        }
    }
}