using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Flyweight
{
    /// <summary>
    /// Flyweight Pattern
    /// 运用共享技术有效的支持大量细粒度的对象
    /// </summary>
    public class FlyweightDemo
    {
        public static void Run()
        {
            string list = "ABABABB";
            char[] chars = list.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            foreach (char c in chars)
            {
                Character processor = factory.GetCharacter(c);
                processor.Display();
            }
        }
    }
}
