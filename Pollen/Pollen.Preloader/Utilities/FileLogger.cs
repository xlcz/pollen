using System.Globalization;

namespace Pollen.Preloader.Utilities;

public static class FileLogger
{
    public static void WriteCrucialError(string txt)
    {
        File.WriteAllText($"pollen_error_{DateTime.Now.ToString(CultureInfo.CurrentCulture)}.log", txt);
        Environment.Exit(-1);
    }
}