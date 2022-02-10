using System;

internal class Calendar
{
    public event Action<DateTime> EveryDayNotification;

    public void Simulate(DateTime startTime, DateTime endTime)
    {
        throw new NotImplementedException();
    }
}