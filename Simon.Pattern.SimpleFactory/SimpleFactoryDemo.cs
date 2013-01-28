using System;
using Simon.Pattern.Library;

namespace Simon.Pattern.SimpleFactory
{
    /// <summary>
    /// Simple Factory Pattern
    /// 属于创建型模式，通过一个静态方法实例化不同的对象
    /// 简单工厂是参数化的工厂方法模式
    /// </summary>
    public class SimpleFactoryDemo
    {
        public static void Run()
        {
            CashBase cash = CashFactory.Create("Normal");
            Console.WriteLine(cash.AcceptCash(1000));

            CashBase cash2 = CashFactory.Create(typeof(CashBase).Assembly.GetName(), "CashNormal") as CashBase;
            Console.WriteLine(cash2.AcceptCash(1000));
        }
    }
}
