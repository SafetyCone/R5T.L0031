using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.L0031.T000
{
    [StrongTypeImplementationMarker]
    public class ContextOperationsSequence<TContext> : TypedBase<IEnumerable<Func<TContext, Task>>>, IStrongTypeImplementationMarker,
        IContextOperationsSequence<TContext>
    {
        public ContextOperationsSequence(IEnumerable<Func<TContext, Task>> value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(IEnumerable<Func<TContext, Task>> a, IEnumerable<Func<TContext, Task>> b)
        {
            // Leave unimplemented for now, but a useful resource is https://stackoverflow.com/a/673246.
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(IEnumerable<Func<TContext, Task>> a, IEnumerable<Func<TContext, Task>> b)
        {
            var output = Enumerable.SequenceEqual(a, b);
            return output;
        }
    }
}
