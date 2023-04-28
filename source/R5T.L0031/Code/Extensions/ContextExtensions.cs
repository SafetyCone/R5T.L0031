using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace R5T.L0031.Extensions
{
    public static class ContextExtensions
    {
        public static void Run<TContext>(this TContext context,
            IEnumerable<Action<TContext>> operations)
        {
            Instances.ContextOperator.In_Context(
                context,
                operations);
        }

        public static void Run<TContext>(this TContext context,
            params Action<TContext>[] operations)
        {
            Instances.ContextOperator.In_Context(
                context,
                operations);
        }

        public static Task Run<TContext>(this TContext context,
            IEnumerable<Func<TContext, Task>> operations)
        {
            return Instances.ContextOperator.In_Context(
                context,
                operations);
        }

        public static Task Run<TContext>(this TContext context,
            params Func<TContext, Task>[] operations)
        {
            return Instances.ContextOperator.In_Context(
                context,
                operations.AsEnumerable());
        }
    }
}
