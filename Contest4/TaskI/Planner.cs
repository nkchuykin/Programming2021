using System;
using System.Collections.Generic;

internal sealed class Planner
{
    private List<Task> Tasks { get; }

    public Planner(List<Task> tasks)
    {
        throw new NotImplementedException();
    }

    public static Planner operator +(Planner firstPlanner, Planner secondPlanner)
    {
        throw new NotImplementedException();
    }

    public static Planner operator -(Planner firstPlanner, Planner secondPlanner)
    {
        throw new NotImplementedException();
    }

    public static Planner operator +(Planner planner, Task task)
    {
        throw new NotImplementedException();
    }

    public static Planner operator -(Planner planner, Task task)
    {
        throw new NotImplementedException();
    }
}