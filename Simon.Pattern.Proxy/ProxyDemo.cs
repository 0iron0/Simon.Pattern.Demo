using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Proxy
{
    public class ProxyDemo
    {
        public static void Run()
        {
            IReporter proxy = new ProxyReporter();
            proxy.Add("I am Simon.");
        }
    }
}
