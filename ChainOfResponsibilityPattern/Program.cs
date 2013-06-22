using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main()
        {
            ExpenseHandler william = new ExpenseHandler(new Employee("William Worker", decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("Mary Manager", new decimal(1000)));
            ExpenseHandler victor = new ExpenseHandler(new Employee("Victor Vicepres", new decimal(2000)));
            ExpenseHandler paula = new ExpenseHandler(new Employee("Paula President", new decimal(5000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            decimal expenseReportAmount;
            if (ConsoleInput.TryReadDecimal("Expense Report Amount: ", out expenseReportAmount))
            {
                IExpenseReport expense = new ExpenseReport(expenseReportAmount);

                ApprovalResponse response = william.Approve(expense);

                Console.WriteLine("The request was {0}.", response);

            }

            Console.ReadKey();
        }

/*
        static void Main()
        {
            var managers = new List<Employee>
                {
                    new Employee("William Worker", decimal.Zero),
                    new Employee("Mary Manager", new decimal(1000)),
                    new Employee("Victor Vicepres", new decimal(2000)),
                    new Employee("Paula President", new decimal(5000))
                };

            decimal expenseReportAmount;
            while (ConsoleInput.TryReadDecimal("Expense Report Amount: ", out expenseReportAmount))
            {
                IExpenseReport expenseReport = new ExpenseReport(expenseReportAmount);
                bool expenseProcessed = false;
                foreach (var approver in managers)
                {
                    ApprovalResponse approvalResponse = approver.ApproveExpense(expenseReport);
                    if (approvalResponse!=ApprovalResponse.BeyondApprovalLimit)
                    {
                        Console.WriteLine("The request was {0}.", approvalResponse);
                        expenseProcessed = true;
                        break;
                    }
                }
                if (!expenseProcessed)
                {
                    Console.WriteLine("No one able to approve your expense.");
                }
            }

            Console.ReadKey();
        }
*/
    }
}
