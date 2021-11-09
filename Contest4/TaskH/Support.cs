using System;
using System.Collections.Generic;

internal sealed class Support
{
    public IEnumerable<Task> Tasks => throw new NotImplementedException();

    public Support()
    {
        throw new NotImplementedException();
    }

    public int OpenTask(string text)
    {
        throw new NotImplementedException();
    }

    public void CloseTask(int id, string answer)
    {
        throw new NotImplementedException();
    }

    public List<Task> GetAllUnresolvedTasks()
    {
        throw new NotImplementedException();
    }

    public void CloseAllUnresolvedTasksWithDefaultAnswer(string answer)
    {
        throw new NotImplementedException();
    }

    public string GetTaskInfo(int id) => throw new NotImplementedException();
}