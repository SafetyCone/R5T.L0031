using System;
using System.Threading.Tasks;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.L0031.T000
{
    [StrongTypeImplementationMarker]
    public class ContextConstructor<TContext> : TypedBase<Func<Task<TContext>>>, IStrongTypeImplementationMarker,
        IContextConstructor<TContext>
    {
        public ContextConstructor(Func<Task<TContext>> value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(Func<Task<TContext>> a, Func<Task<TContext>> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(Func<Task<TContext>> a, Func<Task<TContext>> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }
    }
}
