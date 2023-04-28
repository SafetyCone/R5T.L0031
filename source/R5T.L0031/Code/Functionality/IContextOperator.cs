using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;

using R5T.L0031.T000;


namespace R5T.L0031
{
    [FunctionalityMarker]
    public partial interface IContextOperator : IFunctionalityMarker
    {
        public void In_Context<TContext>(
            Func<TContext> contextConstructor,
            IEnumerable<Action<TContext>> contextOperationsSequence,
            Action<TContext> contextDestructor)
        {
            var context = contextConstructor();

            Instances.ActionOperator.Run(
                context,
                contextOperationsSequence);

            contextDestructor(context);
        }

        public async Task In_Context<TContext>(
            Func<TContext> contextConstructor,
            IEnumerable<Func<TContext, Task>> contextOperationsSequence,
            Action<TContext> contextDestructor)
        {
            var context = contextConstructor();

            await Instances.ActionOperator.Run(
                context,
                contextOperationsSequence);

            contextDestructor(context);
        }

        public async Task In_Context<TContext>(
            Func<TContext> contextConstructor,
            IEnumerable<Func<TContext, Task>> contextOperationsSequence,
            Func<TContext, Task> contextDestructor)
        {
            var context = contextConstructor();

            await Instances.ActionOperator.Run(
                context,
                contextOperationsSequence);

            await contextDestructor(context);
        }

        public void In_Context<TContext>(
            ISynchronousContextConstructor<TContext> contextConstructor,
            ISynchronousContextOperationsSequence<TContext> contextOperationsSequence,
            ISynchronousContextDestructor<TContext> contextDestructor)
        {
            this.In_Context(
                contextConstructor.Value,
                contextOperationsSequence.Value,
                contextDestructor.Value);
        }


        public void In_Context<TContext>(
            TContext context,
            IEnumerable<Action<TContext>> contextOperationsSequence)
        {
            Instances.ActionOperator.Run(
                context,
                contextOperationsSequence);
        }

        public void In_Context<TContext>(
            Func<TContext> contextConstructor,
            IEnumerable<Action<TContext>> contextOperationsSequence)
        {
            var context = contextConstructor();

            this.In_Context(
                context,
                contextOperationsSequence);
        }

        public void In_Context<TContext>(
            ISynchronousContextConstructor<TContext> contextConstructor,
            IEnumerable<Action<TContext>> contextOperationsSequence)
        {
            this.In_Context(
                contextConstructor.Value,
                contextOperationsSequence);
        }

        public async Task In_Context<TContext>(
            Func<Task<TContext>> contextConstructor,
            IEnumerable<Action<TContext>> contextOperationsSequence)
        {
            var context = await contextConstructor();

            this.In_Context(
                context,
                contextOperationsSequence);
        }

        public Task In_Context<TContext>(
            IContextConstructor<TContext> contextConstructor,
            IEnumerable<Action<TContext>> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor.Value,
                contextOperationsSequence);
        }

        public void In_Context<TContext>(
            TContext context,
            params Action<TContext>[] contextOperationsSequence)
        {
            this.In_Context(
                context,
                contextOperationsSequence.AsEnumerable());
        }

        public void In_Context<TContext>(
            Func<TContext> contextConstructor,
            params Action<TContext>[] contextOperationsSequence)
        {
            this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public void In_Context<TContext>(
            ISynchronousContextConstructor<TContext> contextConstructor,
            params Action<TContext>[] contextOperationsSequence)
        {
            this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public Task In_Context<TContext>(
            Func<Task<TContext>> contextConstructor,
            params Action<TContext>[] contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public Task In_Context<TContext>(
            IContextConstructor<TContext> contextConstructor,
            params Action<TContext>[] contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public void In_Context<TContext>(
            TContext context,
            ISynchronousContextOperationsSequence<TContext> contextOperationsSequence)
        {
            this.In_Context(
                context,
                contextOperationsSequence.Value);
        }

        public void In_Context<TContext>(
            Func<TContext> contextConstructor,
            ISynchronousContextOperationsSequence<TContext> contextOperationsSequence)
        {
            this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }

        public void In_Context<TContext>(
            ISynchronousContextConstructor<TContext> contextConstructor,
            ISynchronousContextOperationsSequence<TContext> contextOperationsSequence)
        {
            this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }

        public Task In_Context<TContext>(
            Func<Task<TContext>> contextConstructor,
            ISynchronousContextOperationsSequence<TContext> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }

        public Task In_Context<TContext>(
            IContextConstructor<TContext> contextConstructor,
            ISynchronousContextOperationsSequence<TContext> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }

        public Task In_Context<TContext>(
            TContext context,
            IEnumerable<Func<TContext, Task>> contextOperationsSequence)
        {
            return Instances.ActionOperator.Run(
                context,
                contextOperationsSequence);
        }

        public Task In_Context<TContext>(
            Func<TContext> contextConstructor,
            IEnumerable<Func<TContext, Task>> contextOperationsSequence)
        {
            var context = contextConstructor();

            return this.In_Context(
                context,
                contextOperationsSequence);
        }

        public Task In_Context<TContext>(
            ISynchronousContextConstructor<TContext> contextConstructor,
            IEnumerable<Func<TContext, Task>> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor.Value,
                contextOperationsSequence);
        }

        public async Task In_Context<TContext>(
            Func<Task<TContext>> contextConstructor,
            IEnumerable<Func<TContext, Task>> contextOperationsSequence)
        {
            var context = await contextConstructor();

            await this.In_Context(
                context,
                contextOperationsSequence);
        }

        public Task In_Context<TContext>(
            IContextConstructor<TContext> contextConstructor,
            IEnumerable<Func<TContext, Task>> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor.Value,
                contextOperationsSequence);
        }

        public Task In_Context<TContext>(
            TContext context,
            params Func<TContext, Task>[] contextOperationsSequence)
        {
            return this.In_Context(
                context,
                contextOperationsSequence.AsEnumerable());
        }

        public Task In_Context<TContext>(
            Func<TContext> contextConstructor,
            params Func<TContext, Task>[] contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public Task In_Context<TContext>(
            ISynchronousContextConstructor<TContext> contextConstructor,
            params Func<TContext, Task>[] contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public Task In_Context<TContext>(
            Func<Task<TContext>> contextConstructor,
            params Func<TContext, Task>[] contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public Task In_Context<TContext>(
            IContextConstructor<TContext> contextConstructor,
            params Func<TContext, Task>[] contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.AsEnumerable());
        }

        public Task In_Context<TContext>(
            TContext context,
            IContextOperationsSequence<TContext> contextOperationsSequence)
        {
            return this.In_Context(
                context,
                contextOperationsSequence.Value);
        }

        public Task In_Context<TContext>(
            Func<TContext> contextConstructor,
            IContextOperationsSequence<TContext> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }

        public Task In_Context<TContext>(
            ISynchronousContextConstructor<TContext> contextConstructor,
            IContextOperationsSequence<TContext> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }

        public Task In_Context<TContext>(
            Func<Task<TContext>> contextConstructor,
            IContextOperationsSequence<TContext> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }

        public Task In_Context<TContext>(
            IContextConstructor<TContext> contextConstructor,
            IContextOperationsSequence<TContext> contextOperationsSequence)
        {
            return this.In_Context(
                contextConstructor,
                contextOperationsSequence.Value);
        }
    }
}
