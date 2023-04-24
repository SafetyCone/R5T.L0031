using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.L0031.T000
{
    [FunctionalityMarker]
    public partial interface IFunctionOperator : IFunctionalityMarker
    {
        public ContextOperationsSequence<TContext> ToContextOperationsSequence<TContext>(
            IEnumerable<Func<TContext, Task>> value)
        {
            var output = new ContextOperationsSequence<TContext>(value);
            return output;
        }

        public SynchronousContextConstructor<TContext> ToSynchronousContextConstructor<TContext>(
            Func<TContext> value)
        {
            var output = new SynchronousContextConstructor<TContext>(value);
            return output;
        }

        public ContextConstructor<TContext> ToContextConstructor<TContext>(
            Func<Task<TContext>> value)
        {
            var output = new ContextConstructor<TContext>(value);
            return output;
        }
    }
}
