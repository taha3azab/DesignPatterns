namespace ChainOfResponsibilityPattern
{
    internal interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expense);
        void RegisterNext(IExpenseHandler expenseHandler);
    }
}