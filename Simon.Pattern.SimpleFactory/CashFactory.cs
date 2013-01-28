using System;
using Simon.Pattern.Library;
using System.Reflection;

namespace Simon.Pattern.SimpleFactory
{
    public class CashFactory
    {
        public static CashBase Create(string type)
        {
            CashType cashType = (CashType)Enum.Parse(typeof(CashType), type);
            CashBase cashBase = null;
            switch (cashType)
            { 
                case CashType.Normal:
                    cashBase = new CashNormal();
                    break;
                case CashType.Rebate:
                    cashBase = new CashRebate(0.8);
                    break;
                case CashType.Return:
                    cashBase = new CashReturn(300, 100);
                    break;
                default:
                    throw new ArgumentException("type");
            }
            return cashBase;
        }

        /// <summary>
        /// 通过反射可以简化swich判断，也有利于通过配置文件配置
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object Create(AssemblyName name,string type)
        {
            return Assembly.Load(name).CreateInstance(type);
        }
    }

    public enum CashType
    { 
        Normal,
        Rebate,
        Return
    }
}
