using HotChocolateMessages.Data;
using HotChocolateMessages.Graph.Types;

namespace HotChocolateMessages.Graph;

public class Query
{
    public List<Message> Messages([Service] IStore store)
    {
        return store.GetMessages();
    }
}