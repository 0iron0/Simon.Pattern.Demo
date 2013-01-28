using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Singleton
{
    /// <summary>
    /// Singleton Pattern
    /// 保证一个类只有一个实例，并提供访问一个全局的访问点
    /// </summary>
    public class SingletonDemo
    {
        public static void Run()
        {
            Log log = Log.GetInstance();
            log.Write("Hello world.");

            Log log2 = Log.Instance;
            log.Write("the same instance");
        }
    }
}
