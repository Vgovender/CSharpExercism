static class LogLine
{
    public static string Message(string logLine) => 
        (logLine.Contains("[ERROR]:") || logLine.Contains("[WARNING]:") || logLine.Contains("[INFO]:")) 
        ? logLine.Substring(logLine.IndexOf(':') + 1).Trim() 
        : "";

    public static string LogLevel(string logLine) => 
        (logLine.Contains("[ERROR]:") || logLine.Contains("[WARNING]:") || logLine.Contains("[INFO]:")) 
        ? logLine.Substring(logLine.IndexOf('[') + 1,logLine.IndexOf(']') - 1).Trim().ToLower()
        : "";

    public static string Reformat(string logLine) => 
        (logLine.Contains("[ERROR]:") || logLine.Contains("[WARNING]:") || logLine.Contains("[INFO]:")) ?
         logLine.Substring(logLine.IndexOf(':') + 1).Trim() +
        " ("+logLine.Substring(logLine.IndexOf('[') + 1,logLine.IndexOf(']') - 1).Trim().ToLower()+")"
        : "";
}
