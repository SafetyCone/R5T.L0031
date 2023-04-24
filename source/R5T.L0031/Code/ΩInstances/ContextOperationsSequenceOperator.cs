using System;


namespace R5T.L0031
{
    public class ContextOperationsSequenceOperator : IContextOperationsSequenceOperator
    {
        #region Infrastructure

        public static IContextOperationsSequenceOperator Instance { get; } = new ContextOperationsSequenceOperator();


        private ContextOperationsSequenceOperator()
        {
        }

        #endregion
    }
}
