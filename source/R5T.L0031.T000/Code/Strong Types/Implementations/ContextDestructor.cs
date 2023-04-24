using System;
using System.Threading.Tasks;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.L0031.T000
{
    [StrongTypeImplementationMarker]
    public class ContextDestructor<TContext> : TypedBase<Action<TContext, Task>>, IStrongTypeImplementationMarker,
        IContextDestructor<TContext>
    {
        public ContextDestructor(Action<TContext, Task> value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(Action<TContext, Task> a, Action<TContext, Task> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(Action<TContext, Task> a, Action<TContext, Task> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }
    }
}
