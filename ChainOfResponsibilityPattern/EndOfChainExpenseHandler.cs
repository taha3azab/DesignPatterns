using System;

namespace ChainOfResponsibilityPattern
{
    internal class EndOfChainExpenseHandler : IExpenseHandler
    {
        private EndOfChainExpenseHandler(){}

        public static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();

        public static EndOfChainExpenseHandler Instance
        {
            get { return _instance; }
        }

        public ApprovalResponse Approve(IExpenseReport expense)
        {
            return ApprovalResponse.Denied;
        }

        public void RegisterNext(IExpenseHandler expenseHandler)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }


    }
}