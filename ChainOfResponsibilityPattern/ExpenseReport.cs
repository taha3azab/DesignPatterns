namespace ChainOfResponsibilityPattern
{
    public class ExpenseReport : IExpenseReport
    {
        public decimal Total { get; private set; }

        public ExpenseReport(decimal total)
        {
            Total = total;
        }
    }
}