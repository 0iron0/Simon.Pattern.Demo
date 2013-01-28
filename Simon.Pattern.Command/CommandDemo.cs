using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Command
{
    /// <summary>
    /// Command Pattern
    /// 将一个请求封装成一个对象，从而使你可以使用不同的请求对客户进行参数化；
    /// 对请求排队或记录请求日志，以及支持可撤销的操作
    /// 优点：把请求一个操作的对象与知道怎么执行一个操作的对象分割开
    /// </summary>
    public class CommandDemo
    {
        public static void Run()
        {
            User u = new User();
            u.Compute('+', 100);
            u.Compute('-', 50);
            u.Compute('*', 10);
            u.Compute('/', 2);
            u.Undo(4);
            u.Redo(3);
        }
    }
}
