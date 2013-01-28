using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.MethodTemplate
{
    /// <summary>
    /// Method Template Pattern
    /// 在抽象类中定义算法的骨架，将具体的步骤实现延迟要子类中
    /// 优点：在不改变算法结构的情况下，重新定义算法的具体步骤
    /// 也可以理解为在父类中通过非抽象方法调用抽象方法
    /// </summary>
    public class MethodTemplateDemo
    {
        public static void Run()
        {
            //SqlBuilderBase sqlBuilder = new SqlBuilderForAccess();
            //Console.WriteLine(sqlBuilder.BuildSqlString("AllDocs", "LastModified", "2012-12-12"));

            Number num = new Number();
            float[] f = { 1,2,3,4};
            CompareMehod com = new CompareMehod();
            num.DoCompare += com.C1;
            num.DoCompare += com.C2;
            Console.WriteLine(num.CompareTo(f));
        }
    }
}
