using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Prototype
{
    /// <summary>
    /// Prototype Pattern
    /// 通过一个对象的实例可以拷贝出多个其他实例
    /// 这样可以节省对象初始化的操作
    /// 可以继承.net中的ICloneable
    /// </summary>
    public class PrototypeDemo
    {
        public static void Run()
        {
            PersonInfo pi = new PersonInfo("Simon", 30);
            pi.IfDeepCopy = true;

            PersonInfo pi2 = pi.Clone() as PersonInfo;
            pi2.Name = "Leo";

            Console.WriteLine(pi.Name);
            Console.WriteLine(pi2.Name);
        }
    }
}
