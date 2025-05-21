using System.Collections.Generic;
using Microsoft.Extensions.AI;

namespace Microsoft.Extensions.AI.Declarative.Abstractions
{
    public class DeclarativeAIContent : AIContent
    {
        public Dictionary<string, object> Inputs { get; }

        public DeclarativeAIContent()
        {
            Inputs = new Dictionary<string, object>();
        }

        public DeclarativeAIContent(Dictionary<string, object> inputs)
        {
            Inputs = inputs;
        }
    }
}
