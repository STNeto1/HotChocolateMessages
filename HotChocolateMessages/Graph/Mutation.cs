using HotChocolateMessages.Data;
using HotChocolateMessages.Graph.Input;
using HotChocolateMessages.Graph.Types;

namespace HotChocolateMessages.Graph;

public class Mutation
{
    public Message AddMessage([Service] IStore store, AddMessage input)
    {
        return store.AddMessage(input);
    }
}