using Microsoft.Extensions.AI;

namespace Microsoft.Extensions.AI.ModelContextProtocol.Tools
{
    public class McpAITool : AITool
    {
        private readonly object _mcpTool;

        public McpAITool(object mcpTool)
        {
            _mcpTool = mcpTool;
        }

        public override string Name => _mcpTool.GetType().Name;

        public override string Description => "MCP defined tool";

        public override IReadOnlyDictionary<string, object?> AdditionalProperties => new Dictionary<string, object?>
        {
            { "McpTool", _mcpTool }
        };
    }
}
