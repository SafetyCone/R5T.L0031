using System;
using System.Collections.Generic;

using R5T.T0132;


namespace R5T.L0031.T000
{
    [FunctionalityMarker]
    public partial interface IActionOperator : IFunctionalityMarker
    {
        public SynchronousContextOperationsSequence<TContext> ToContextOperationsSequence<TContext>(
            IEnumerable<Action<TContext>> value)
        {
            var output = new SynchronousContextOperationsSequence<TContext>(value);
            return output;
        }
    }
}
