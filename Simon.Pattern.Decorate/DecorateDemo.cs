using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Simon.Pattern.Decorate
{
    public class DecorateDemo
    {
        public static void Run()
        {
            //Case1();
            Case2();
        }

        /// <summary>
        /// BufferedStream使用装饰模式
        /// 继承Stream基类，提供同样的接口
        /// 可以封装其他继承自Stream的类，提供缓存的功能
        /// </summary>
        static void Case1()
        {
            string filePath = @"test.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);

            using(FileStream fs = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    Output(bs, "I am Simon.\r\n");
                    Output(bs, "How are you?");
                    bs.Flush();
                }
            }
        }

        static void Output(Stream stream, string value)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(value);
            stream.Write(buffer, 0, buffer.Length);
        }

        static void Case2()
        {
            BufferedReporter reporter = new BufferedReporter(new RealtimeReporter());
            for (int i = 0; i <= 10; i++)
            {
                reporter.Add(i.ToString());
                Thread.Sleep(500);
            }
        }
    }
}
