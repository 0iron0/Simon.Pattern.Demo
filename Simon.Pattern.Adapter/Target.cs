using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("normal request.");
        }
    }

    public class Adaptee
    {
        public void SpecifiedRequest()
        {
            Console.WriteLine("specified request.");
        }
    }

    public class Adapter : Target
    {
        private Adaptee mAdaptee;
        public Adapter()
        {
            this.mAdaptee = new Adaptee();
        }

        public override void Request()
        {
            this.mAdaptee.SpecifiedRequest();
        }
    }
}
