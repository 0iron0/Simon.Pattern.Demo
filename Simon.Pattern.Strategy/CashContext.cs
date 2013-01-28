using Simon.Pattern.Library;
using Simon.Pattern.SimpleFactory;

namespace Simon.Pattern.Strategy
{
    /// <summary>
    /// Strategy pattern
    /// 策略模式：是一种定义一系列算法的方法，从概念上看，所有算法都完成相同的工作
    /// 只是实现不同，可以使用相同的方式调用所有算法，从而减少了各种算法与算法使用类之间的耦合
    /// Context可以封装了具体算法的实例化，对外提供统一的调用行为（接口）
    /// 优点：有利于做单元测
    /// ---------------------------------------------------------------------------------
    /// 下列是Strategy和Simple Facotry pattern的结合
    /// 通过Context类将具体的创建和调用封装起来
    /// 对于外部用户只需要接触Context类即可
    /// </summary>
    public class CashContext
    {
        private CashBase mCashBase;
        public CashContext(string type)
        {
            this.mCashBase = CashFactory.Create(type);
        }

        public double GetResult(double money)
        {
            return this.mCashBase.AcceptCash(money);
        }
    }
}
