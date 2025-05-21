using System;

namespace Microsoft.Extensions.AI.Declarative.Abstractions
{
    public abstract class DeclarativeAIOptimizer
    {
        public abstract void ZeroFeedback();
        public abstract void Backward(object output, OptimizerFeedback feedback);
        public abstract void Step();
    }
}
