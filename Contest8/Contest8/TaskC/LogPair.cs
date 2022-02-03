internal class LogPair
{
    public Print Method { get; set; }

    public string Log { get; set; }

    public LogPair(Print method, string log)
    {
        Method = method;
        Log = log;
    }
}