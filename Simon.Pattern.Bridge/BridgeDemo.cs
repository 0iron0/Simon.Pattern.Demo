using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Bridge
{
    /// <summary>
    /// Bridge Pattern
    /// 将抽象部分与它的实现部分分离，使他们都可以独立的变化
    /// </summary>
    public class BridgeDemo
    {
        public static void Run()
        {
            ReportWriter reportWriter = new BMWReportWriter();
            reportWriter.Report = new HrReport();//bridge
            reportWriter.Write("weekly report");

            reportWriter.Report = new FinanceReport();//bridge
            reportWriter.Write("weekly report");
        }
    }
}
