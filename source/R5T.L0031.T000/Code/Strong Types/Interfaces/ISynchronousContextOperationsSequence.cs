using System;
using System.Collections.Generic;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0031.T000
{
    [StrongTypeMarker]
    public interface ISynchronousContextOperationsSequence<TContext> : IStrongTypeMarker,
        ITyped<IEnumerable<Action<TContext>>>
    {
    }
}
