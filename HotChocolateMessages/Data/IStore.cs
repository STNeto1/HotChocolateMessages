using HotChocolateMessages.Graph.Input;
using HotChocolateMessages.Graph.Types;

namespace HotChocolateMessages.Data;

public interface IStore
{
    Message AddMessage(AddMessage input);
    List<Message> GetMessages();
}