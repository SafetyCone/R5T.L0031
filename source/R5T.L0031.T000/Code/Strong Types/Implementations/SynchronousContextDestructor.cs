using System;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.L0031.T000
{
    [StrongTypeImplementationMarker]
    public class SynchronousContextDestructor<TContext> : TypedBase<Action<TContext>>, IStrongTypeImplementationMarker,
        ISynchronousContextDestructor<TContext>
    {
        public SynchronousContextDestructor(Action<TContext> value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(Action<TContext> a, Action<TContext> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(Action<TContext> a, Action<TContext> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }
    }
}
