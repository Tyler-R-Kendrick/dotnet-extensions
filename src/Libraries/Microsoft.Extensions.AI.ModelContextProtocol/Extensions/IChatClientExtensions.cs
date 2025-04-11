using Microsoft.Extensions.AI;

namespace Microsoft.Extensions.AI.ModelContextProtocol.Extensions
{
    public static class IChatClientExtensions
    {
        public static McpAITool ToMcpServer(this IChatClient chatClient)
        {
            // Implementation of the ToMcpServer extension method
            return new McpAITool(chatClient);
        }
    }
}
