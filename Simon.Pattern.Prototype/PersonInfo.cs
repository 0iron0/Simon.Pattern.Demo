using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Simon.Pattern.Prototype
{
    [Serializable]
    public class PersonInfo : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IfDeepCopy { get; set; }

        public PersonInfo(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            IfDeepCopy = false;
        }

        public object Clone()
        {
            if (IfDeepCopy)
                return DeepCopy();
            else
                return this.MemberwiseClone();//浅拷贝：值类型按位复制，引用类型只复制引用
        }

        public object DeepCopy()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);
                ms.Position = 0;
                return bf.Deserialize(ms);
            }
        }
    }
}
