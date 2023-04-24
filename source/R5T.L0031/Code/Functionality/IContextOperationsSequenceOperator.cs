using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;

using R5T.L0031.T000;
using R5T.L0031.T000.Extensions;

namespace R5T.L0031
{
    [FunctionalityMarker]
    public partial interface IContextOperationsSequenceOperator : IFunctionalityMarker
    {
        public SynchronousContextOperationsSequence<TContext> Extend<TContext>(
            ISynchronousContextOperationsSequence<TContext> sequence,
            ISynchronousContextOperationsSequence<TContext> appendix)
        {
            var output = sequence.Value
                .AppendRange(appendix.Value)
                .ToContextOperationsSequence();

            return output;
        }

        public TContextOperationsSequence Extend<TContext, TContextOperationsSequence>(
            ISynchronousContextOperationsSequence<TContext> sequence,
            ISynchronousContextOperationsSequence<TContext> appendix,
            Func<IEnumerable<Action<TContext>>, TContextOperationsSequence> contextOperationsSequenceConstructor)
            where TContextOperationsSequence : ISynchronousContextOperationsSequence<TContext>
        {
            var outputValue = sequence.Value
                .AppendRange(appendix.Value)
                ;

            var output = contextOperationsSequenceConstructor(outputValue);
            return output;
        }

        public ContextOperationsSequence<TContext> Extend<TContext>(
            IContextOperationsSequence<TContext> sequence,
            IContextOperationsSequence<TContext> appendix)
        {
            var output = sequence.Value
                .AppendRange(appendix.Value)
                .ToContextOperationsSequence();

            return output;
        }

        public TContextOperationsSequence Extend<TContext, TContextOperationsSequence>(
            IContextOperationsSequence<TContext> sequence,
            IContextOperationsSequence<TContext> appendix,
            Func<IEnumerable<Func<TContext, Task>>, TContextOperationsSequence> contextOperationsSequenceConstructor)
            where TContextOperationsSequence : IContextOperationsSequence<TContext>
        {
            var outputValue = sequence.Value
                .AppendRange(appendix.Value)
                ;

            var output = contextOperationsSequenceConstructor(outputValue);
            return output;
        }
    }
}
