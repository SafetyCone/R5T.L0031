using System;


namespace R5T.L0031.T000
{
    public class ActionOperator : IActionOperator
    {
        #region Infrastructure

        public static IActionOperator Instance { get; } = new ActionOperator();


        private ActionOperator()
        {
        }

        #endregion
    }
}
