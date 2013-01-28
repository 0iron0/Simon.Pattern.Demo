using System;

namespace Simon.Pattern.Strategy
{
    public class StrategyDemo
    {
        public static void Run()
        {
            CashContext ctx = new CashContext("Normal");
            Console.WriteLine(ctx.GetResult(1000));
        }
    }
}
