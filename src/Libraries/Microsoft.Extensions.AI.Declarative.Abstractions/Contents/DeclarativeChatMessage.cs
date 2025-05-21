using System.Collections.Generic;
using Microsoft.Extensions.AI;

namespace Microsoft.Extensions.AI.Declarative.Abstractions
{
    public class DeclarativeChatMessage : ChatMessage
    {
        public DeclarativeChatMessage(params DeclarativeAIContent[] contents)
            : base(ChatRole.User, new List<AIContent>(contents))
        {
        }
    }
}
