using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simon.Pattern.Library;

namespace Simon.Pattern.MethodFactory
{
    /// <summary>
    /// Method Factory
    /// 抽象出工厂创建方法，不同的工厂创建不同的对象
    /// .net中的IEnumerable/IEnumerator就是方法工厂模式
    /// </summary>
    public class MethodFactoryDemo
    {
        public static void Run()
        {
            CashFactoryBase factory = new CashNormalFactory();
            CashBase cash = factory.Create();
            Console.WriteLine(cash.AcceptCash(1000));
        }
    }
}
