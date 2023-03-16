using HotChocolate.Language;
using HotChocolateMessages.Graph.Input;
using HotChocolateMessages.Graph.Types;

namespace HotChocolateMessages.Data;

public class Store : IStore
{
    private readonly List<Message> _messages = new();


    public Message AddMessage(AddMessage input)
    {
        var newMessage = new Message
        {
            Id = _messages.Count + 1,
            Text = input.Text
        };

        _messages.Push(newMessage);

        return newMessage;
    }

    public List<Message> GetMessages()
    {
        return _messages;
    }
}