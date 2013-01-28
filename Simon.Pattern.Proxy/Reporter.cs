using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Proxy
{
    public interface IReporter
    {
        void Add(string message);
    }

    public class RealReporter : IReporter
    {
        public void Add(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ProxyReporter : IReporter
    {
        private IReporter mReporter = null;

        public void Add(string message)
        {
            if(null == this.mReporter)
                this.mReporter = new RealReporter();    
            this.mReporter.Add(message);
        }
    }
}
