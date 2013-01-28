using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Observer
{
    public abstract class SubjectBase
    {
        private List<ObserverBase> mObservers = new List<ObserverBase>();
        public void Attach(ObserverBase o)
        {
            mObservers.Add(o);
        }

        public void Detach(ObserverBase o)
        {
            mObservers.Remove(o);
        }

        public void Notify()
        {
            foreach (ObserverBase o in this.mObservers)
            {
                o.Update();
            }
        }
    }

    public class ConcreteSubject : SubjectBase
    {
        public string SubjectState { get; set; }
    }

    public abstract class ObserverBase
    {
        public abstract void Update();
    }

    public class ConcreteObserver : ObserverBase
    {
        private string mName;
        private SubjectBase mSubject;

        public ConcreteObserver(SubjectBase subject, string name)
        {
            this.mName = name;
            this.mSubject = subject;
        }

        public override void Update()
        {
            Console.WriteLine("Observer {0}'s state is {1}", this.mName, (this.mSubject as ConcreteSubject).SubjectState);            
        }
    }
}
