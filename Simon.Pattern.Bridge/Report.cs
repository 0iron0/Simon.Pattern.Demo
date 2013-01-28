using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Bridge
{
    public interface IReport
    {
        void WriteReport(string message);
    }

    public class HrReport : IReport
    {

        public void WriteReport(string message)
        {
            Console.WriteLine("HR report: {0}", message);
        }
    }

    public class FinanceReport : IReport
    {

        public void WriteReport(string message)
        {
            Console.WriteLine("Finance report: {0}", message);
        }
    }

    public abstract class ReportWriter
    {
        public IReport Report { get; set; }//bridge

        public void NewReport(string filename)
        {
            Console.WriteLine("Create new report file.");
        }
        public abstract void Write(string message);

        public void SaveReport()
        {
            Console.WriteLine("Save report file");
        }
    }


    public class BMWReportWriter : ReportWriter
    {
        public override void Write(string message)
        {
            this.Report.WriteReport(message);
        }
    }

    public class FerrariReportWriter : ReportWriter
    {
        public override void Write(string message)
        {
            this.Report.WriteReport(message);
        }
    }
}
