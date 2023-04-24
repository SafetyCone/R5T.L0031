using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.L0031.T000.Extensions
{
    public static class FunctionExtensions
    {
        public static ContextOperationsSequence<TContext> ToContextOperationsSequence<TContext>(
            this IEnumerable<Func<TContext, Task>> value)
        {
            return Instances.FunctionOperator.ToContextOperationsSequence(value);
        }

        public static SynchronousContextConstructor<TContext> ToSynchronousContextConstructor<TContext>(
            this Func<TContext> value)
        {
            return Instances.FunctionOperator.ToSynchronousContextConstructor(value);
        }

        public static ContextConstructor<TContext> ToContextConstructor<TContext>(
            this Func<Task<TContext>> value)
        {
            return Instances.FunctionOperator.ToContextConstructor(value);
        }
    }
}
