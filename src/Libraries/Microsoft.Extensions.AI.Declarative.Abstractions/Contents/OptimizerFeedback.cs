using System;

namespace Microsoft.Extensions.AI.Declarative.Abstractions
{
    public class OptimizerFeedback
    {
        public string? FeedbackType { get; set; }
        public string? FeedbackContent { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Annotator { get; set; }
    }
}
