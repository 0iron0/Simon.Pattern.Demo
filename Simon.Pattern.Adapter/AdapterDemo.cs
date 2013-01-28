using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Adapter
{
    /// <summary>
    /// Adapter Pattern
    /// 将一个类的接口转换（包装）为另一个客户希望的接口，使接口不兼容的类可以协同工作
    /// 特点：当对象的行为类似但接口不同时，可以使用Adapter将不兼容的接口封装为统一的接口
    /// .net应用IDataAdapter
    /// </summary>
    public class AdapterDemo
    {
        public static void Run()
        {
            Adapter a = new Adapter();
            a.Request();
        }
    }
}
