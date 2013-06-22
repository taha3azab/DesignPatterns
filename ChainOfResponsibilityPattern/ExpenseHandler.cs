namespace ChainOfResponsibilityPattern
{
    internal class ExpenseHandler : IExpenseHandler
    {
        private readonly IExpenseApprover _approver;
        private IExpenseHandler _next;

        public ExpenseHandler(IExpenseApprover approver)
        {
            _approver = approver;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expense)
        {
            ApprovalResponse response = _approver.ApproveExpense(expense);

            if(response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expense);
            }
            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
    }
}