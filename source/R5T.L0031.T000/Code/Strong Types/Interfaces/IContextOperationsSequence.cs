using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0031.T000
{
    [StrongTypeMarker]
    public interface IContextOperationsSequence<TContext> : IStrongTypeMarker,
        ITyped<IEnumerable<Func<TContext, Task>>>
    {
    }
}
