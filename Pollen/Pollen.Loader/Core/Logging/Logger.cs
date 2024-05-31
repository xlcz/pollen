using System.Text;

namespace Pollen.Loader.Core.Logging;

public class Logger
{
    private string _category;
    private static List<string> _buffer = new List<string>();

    private static readonly Dictionary<LogType, string> LogColours = new()
    {
        { LogType.Error, "#EA4034" },
        { LogType.Info, "#00FFFB" },
        { LogType.Debug, "#A600FF" }
    };
    
    public Logger(string category)
    {
        this._category = category;
    }

    private void Write(string log)
    {
        Console.WriteLine(log);
    }

    public void Log(LogType logType, string txt)
    {
        StringBuilder builder = new();
        StringBuilder bufferBuilder = new();
        builder.Append('[');
        bufferBuilder.Append(builder.ToString());
        builder.Append(logType.ToString().Pastel(LogColours[logType]));
        bufferBuilder.Append(logType.ToString());
        builder.Append("] ");
        bufferBuilder.Append("] ");
        builder.Append('[');
        bufferBuilder.Append("[");
        builder.Append(_category.Pastel("#ff0055"));
        bufferBuilder.Append(_category);
        builder.Append("] ");
        bufferBuilder.Append("] ");
        builder.Append(txt);
        bufferBuilder.Append(txt);
        
        _buffer.Add(bufferBuilder.ToString());
    }

    public void MultilineLog(LogType logType, string txt, string lines)
    {
        Log(logType, txt + $"\n{VerticalSeperator()}{lines}\n{VerticalSeperator()}");
    }

    public static void WriteBuffer()
    {
        File.WriteAllLines(Configuration.GetConfig().PathToLatestLog, _buffer);
    }

    public string VerticalSeperator() =>
        new StringBuilder(50).Insert(0, "―", 50).Append('\n').ToString();
}

public enum LogType 
{
    Error, // EA4034
    Info, // 00FFFB
    Debug // A600FF
}