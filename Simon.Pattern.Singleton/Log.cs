using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Singleton
{
    /// <summary>
    /// 懒汉式单例
    /// </summary>
    public class Log
    {
        private static Log mInstance;
        private static readonly object mSyncRoot = new object();

        private Log() { }//私有构造函数保证类不能在外部被实例化

        //通过方法获取实例
        public static Log GetInstance()
        {
            if (null == mInstance)
            {
                lock (mSyncRoot)
                {
                    if (null == mInstance)
                    {
                        mInstance = new Log();
                    }
                }
            }

            return mInstance;
        }

        //通过属性获取实例
        public static Log Instance
        {
            get
            {
                if (null == mInstance)
                {
                    lock (mSyncRoot)
                    {
                        if (null == mInstance)
                        {
                            mInstance = new Log();
                        }
                    }
                }
                return mInstance;
            }
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    /// <summary>
    /// 饿汉式单例
    /// </summary>
    public sealed class Singleton//sealed保证类不会被继承，不可能通过子类实例化
    {
        private static readonly Singleton mInstance = new Singleton();
        private Singleton() { }

        public static Singleton GetInstance()
        {
            return mInstance;
        }
    }
}
