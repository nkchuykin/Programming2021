using System;
using System.Collections.Generic;

internal class MessageQueue
{
    public MessageQueue(int queueSize)
    {
        throw new NotImplementedException();
    }

    public void Push(Message message)
    {
        throw new NotImplementedException();
    }

    public int Size => throw new NotImplementedException();
    
    public Message this[int index] => throw new NotImplementedException();
    
    public List<Message> this[int from, int to] => throw new NotImplementedException();
}