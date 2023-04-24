using System;
using System.Threading.Tasks;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0031.T000
{
    [StrongTypeMarker]
    public interface IContextDestructor<TContext> : IStrongTypeMarker,
        ITyped<Action<TContext, Task>>
    {
    }
}
