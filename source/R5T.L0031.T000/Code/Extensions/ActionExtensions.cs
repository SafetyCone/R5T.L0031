using System;
using System.Collections.Generic;


namespace R5T.L0031.T000.Extensions
{
    public static class ActionExtensions
    {
        public static SynchronousContextOperationsSequence<TContext> ToContextOperationsSequence<TContext>(
            this IEnumerable<Action<TContext>> value)
        {
            return Instances.ActionOperator.ToContextOperationsSequence(value);
        }
    }
}
