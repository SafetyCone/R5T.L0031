using System;


namespace R5T.L0031
{
    public class ContextOperator : IContextOperator
    {
        #region Infrastructure

        public static IContextOperator Instance { get; } = new ContextOperator();


        private ContextOperator()
        {
        }

        #endregion
    }
}
