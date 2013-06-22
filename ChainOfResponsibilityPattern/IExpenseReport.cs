using System;

namespace ChainOfResponsibilityPattern
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }
}