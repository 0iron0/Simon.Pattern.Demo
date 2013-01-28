using System;
using Simon.Pattern.SimpleFactory;
using Simon.Pattern.Strategy;
using Simon.Pattern.Decorate;
using Simon.Pattern.Proxy;
using Simon.Pattern.MethodFactory;
using Simon.Pattern.Prototype;
using Simon.Pattern.MethodTemplate;
using Simon.Pattern.Facade;
using Simon.Pattern.Builder;
using Simon.Pattern.Observer;
using Simon.Pattern.AbstractFactory;
using Simon.Pattern.Adapter;
using Simon.Pattern.Composite;
using Simon.Pattern.Iterator;
using Simon.Pattern.Singleton;
using Simon.Pattern.Bridge;
using Simon.Pattern.Command;
using Simon.Pattern.ChainOfResposibility;
using Simon.Pattern.Mediator;
using Simon.Pattern.Flyweight;

namespace Simon.Pattern.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleFactoryDemo.Run();

            //StrategyDemo.Run();

            //DecorateDemo.Run();

            //ProxyDemo.Run();

            //MethodFactoryDemo.Run();

            //PrototypeDemo.Run();

            //MethodTemplateDemo.Run();

            //FacadeDemo.Run();

            //BuilderDemo.Run();

            //ObserverDemo.Run();

            //AbstractFactoryDemo.Run();

            //AdapterDemo.Run();

            //CompositeDemo.Run();

            //IteratorDemo.Run();

            //SingletonDemo.Run();

            //BridgeDemo.Run();

            //CommandDemo.Run();

            //ChainOfResposibilityDemo.Run();

            //MediatorDemo.Run();

            FlyweightDemo.Run();

            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
