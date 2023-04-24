using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.L0031.T000
{
    [StrongTypeImplementationMarker]
    public class SynchronousContextOperationsSequence<TContext> : TypedBase<IEnumerable<Action<TContext>>>, IStrongTypeImplementationMarker,
        ISynchronousContextOperationsSequence<TContext>
    {
        public SynchronousContextOperationsSequence(IEnumerable<Action<TContext>> value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(IEnumerable<Action<TContext>> a, IEnumerable<Action<TContext>> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(IEnumerable<Action<TContext>> a, IEnumerable<Action<TContext>> b)
        {
            var output = Enumerable.SequenceEqual(a, b);
            return output;
        }
    }
}
