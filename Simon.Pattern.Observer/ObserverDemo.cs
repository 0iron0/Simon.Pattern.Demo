using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Observer
{
    /// <summary>
    /// Observer Pattern（也叫发布-订阅模式）
    /// 定义了一种一对多的依赖关系，让多个观察者可以同时监听一个主题对象
    /// 当主题对象的状态发生变化时，可以通知所有观察者，让所有观察者可以及时更新对应的状态
    /// 典型应用：事件委托
    /// </summary>
    public class ObserverDemo
    {
        public static void Run()
        {
            //SubjectBase subject = new ConcreteSubject();
            //subject.Attach(new ConcreteObserver(subject, "X"));
            //subject.Attach(new ConcreteObserver(subject, "Y"));
            //(subject as ConcreteSubject).SubjectState = "Boss is back.";
            //subject.Notify();

            Service s = new Service();
            s.Opened += OnOpen;
            s.Open();
        }

        public static void OnOpen()
        {
            Console.WriteLine("Service is opened.");
        }
    }
}
