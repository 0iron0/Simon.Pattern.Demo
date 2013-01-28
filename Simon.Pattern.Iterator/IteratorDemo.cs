using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Simon.Pattern.Iterator
{
    /// <summary>
    /// Iterator Pattern
    /// 提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示
    /// </summary>
    public class IteratorDemo
    {
        public static void Run()
        {
            //Case1();
            Case2();
        }

        /// <summary>
        /// 非泛型实现
        /// 缺点：每个对象都需要定义一个对应的集合对象
        /// </summary>
        static void Case1()
        {
            ItemCollection items = new ItemCollection 
            { 
                new Item{Name="aa", Size=10},
                new Item{Name="bb", Size=20}
            };

            //IEnumerator enumerator = items.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Item item = enumerator.Current as Item;
            //    Console.WriteLine(item.Name);
            //}

            foreach (Item item in items)
            {
                Console.WriteLine(item.Name);
            }
        }

        /// <summary>
        /// 泛型实现
        /// 优点：一个集合可以适应多个不同的对象
        /// </summary>
        static void Case2()
        {
            Collection<Item> items = new Collection<Item> 
            { 
                new Item{Name="aa", Size=10},
                new Item{Name="bb", Size=20}
            };

            //foreach (Item item in items)
            //{
            //    Console.WriteLine(item.Name);
            //}

            IEnumerator<Item> enumerator = items.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }
        }
    }
}
