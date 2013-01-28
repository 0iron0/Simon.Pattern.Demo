using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.AbstractFactory
{
    /// <summary>
    /// Abstract Factory Pattern
    /// 提供一个创建一系列相关或相互依赖对象的接口，而无需指定他们具体的类
    /// </summary>
    public class AbstractFactoryDemo
    {
        public static void Run()
        {
            FactoryBase f = new Factory();
            UserBase u = f.CreateUser("Simon");
            DepartmentBase d = f.CreateDepartment();
            d.AddUser(u);
            Console.WriteLine(d.GetUser(u.GetName()).GetName());
        }
    }
}
