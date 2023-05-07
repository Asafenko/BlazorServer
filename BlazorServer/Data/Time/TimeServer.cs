namespace BlazorServer.Data;

public record TimeServer : ITimeServer
{
    public DateTime GetTime()
    {
        return DateTime.Now;
    }
}