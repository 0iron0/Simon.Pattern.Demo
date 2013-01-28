using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simon.Pattern.Library;

namespace Simon.Pattern.MethodFactory
{
    public abstract class CashFactoryBase
    {
        public abstract CashBase Create();
    }

    public class CashNormalFactory : CashFactoryBase
    {

        public override CashBase Create()
        {
            return new CashNormal();
        }
    }

    public class CashRebateFactory : CashFactoryBase
    {

        public override CashBase Create()
        {
            return new CashRebate(0.8);
        }
    }

    public class CashReturnFactory : CashFactoryBase
    {

        public override CashBase Create()
        {
            return new CashReturn(300, 100);
        }
    }
}
