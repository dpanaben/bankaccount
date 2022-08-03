using System;
namespace learningcsharp
{
    public class InterestEarningAccount : BankAccount
    {
        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }
    }
}

