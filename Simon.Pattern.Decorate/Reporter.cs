using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Simon.Pattern.Decorate
{
    public abstract class ReporterBase
    {
        public abstract void Add(string message);
    }

    public class RealtimeReporter : ReporterBase
    {

        public override void Add(string message)
        {
            Console.WriteLine(message);
        }
    }

    /// <summary>
    /// BufferedReporter可以装饰任何继承自ReporterBase的类
    /// 可以提供相同的接口，同时也可以扩展出其他功能
    /// </summary>
    public class BufferedReporter : ReporterBase
    {
        private ReporterBase mReporter;
        private ArrayList mCache = new ArrayList();

        public BufferedReporter(ReporterBase reporter)
        {
            this.mReporter = reporter;
        }

        public override void Add(string message)
        {
            bool ifNeedClear = false;

            mCache.Add(message);
            if (mCache.Count >= 5)
            {
                foreach (object o in mCache)
                {
                    this.mReporter.Add(o.ToString());
                }
                ifNeedClear = true;
            }

            if (ifNeedClear)
                mCache.Clear();
        }
    }
}
