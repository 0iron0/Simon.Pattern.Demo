using System;

namespace Simon.Pattern.Library
{
    public abstract class CashBase
    {
        public abstract double AcceptCash(double money);
    }

    public class CashNormal : CashBase
    {

        public override double AcceptCash(double money)
        {
            return money;
        }
    }

    public class CashRebate : CashBase
    {
        private double mMoneyRebate = 1d;
        public CashRebate(double moneyRebate)
        {
            this.mMoneyRebate = moneyRebate;
        }

        public override double AcceptCash(double money)
        {
            return money * this.mMoneyRebate;
        }
    }

    public class CashReturn : CashBase
    {
        private double mMoneyCondition = 0.0d;
        private double mMoneyReturn = 0.0d;
        public CashReturn(double moneyCondition, double moneyReturn)
        {
            this.mMoneyCondition = moneyCondition;
            this.mMoneyReturn = moneyReturn;
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= this.mMoneyCondition)
                result = money - Math.Floor(money / this.mMoneyCondition) * mMoneyReturn;
            return result;
        }
    }
}
