namespace Pollen.Preloader;

public static class EnvVars
{
    public static readonly string? 
        DoorstopInitialized,
        DoorstopInvokeDllPath,
        DoorstopProcessPath,
        DoorstopManagedFolderDir,
        DoorstopDllSearchDirs;

    static EnvVars()
    {
        DoorstopInitialized = Environment.GetEnvironmentVariable("DOORSTOP_INITIALIZED");
        DoorstopInvokeDllPath = Environment.GetEnvironmentVariable("DOORSTOP_INVOKE_DLL_PATH");
        DoorstopProcessPath = Environment.GetEnvironmentVariable("DOORSTOP_PROCESS_PATH");
        DoorstopManagedFolderDir = Environment.GetEnvironmentVariable("DOORSTOP_MANAGED_FOLDER_DIR");
        DoorstopDllSearchDirs = Environment.GetEnvironmentVariable("DOORSTOP_MONO_LIB_PATH");
    }
}