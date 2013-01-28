using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Composite
{
    /// <summary>
    /// Composite Pattern
    /// 将对象组成树形结构以表示“部分-整体”的层次关系
    /// 组合模式使得用户对单一对象和组合对象的使用具有一致性
    /// .net中的控件使用组合模式，都集成自Control类
    /// Composite/Decorate/Proxy三种模式非常相似
    /// </summary>
    public class CompositeDemo
    {
        public static void Run()
        {
            Company root = new ConcreteCompany("总公司");
            root.Add(new HrDepartment("总公司HR"));
            root.Add(new FinanceDepartment("总公司财务"));

            Company cc = new ConcreteCompany("长春分公司");
            cc.Add(new HrDepartment("长春分公司HR"));
            cc.Add(new FinanceDepartment("长春分公司财务"));
            root.Add(cc);

            Company dl = new ConcreteCompany("大连分公司");
            dl.Add(new HrDepartment("大连分公司HR"));
            dl.Add(new FinanceDepartment("大连分公司财务"));
            root.Add(dl);

            root.Display(1);

            root.LineOfDuty();
        }
    }
}
