using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.ChainOfResposibility
{
    public class Purchase
    {
        public int Number { get; set; }
        public int Amount { get; set; }
        public string Purpose { get; set; }

        public Purchase(int number, int amount, string purpose)
        {
            this.Number = number;
            this.Amount = amount;
            this.Purpose = purpose;
        }
    }

    public abstract class Approver
    {
        protected Approver mApprover;
        public void SetApprover(Approver approver)
        {
            this.mApprover = approver;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }

    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 1000)
            {
                Console.WriteLine("{0} approved reqeuest #{1}", this.GetType().Name, purchase.Number);
            }
            else if(this.mApprover != null)
            {
                this.mApprover.ProcessRequest(purchase);
            }
        }
    }

    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 5000)
            {
                Console.WriteLine("{0} approved reqeuest #{1}", this.GetType().Name, purchase.Number);
            }
            else if (this.mApprover != null)
            {
                this.mApprover.ProcessRequest(purchase);
            }
        }
    }

    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000)
            {
                Console.WriteLine("{0} approved reqeuest #{1}", this.GetType().Name, purchase.Number);
            }
            else
            {
                Console.WriteLine("Request #{0} requires an executive meetings.", purchase.Number);
            }
        }
    }
}
