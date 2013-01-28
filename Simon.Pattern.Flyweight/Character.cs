using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Flyweight
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> mCache = new Dictionary<char, Character>();
        public Character GetCharacter(char key)
        {
            if (mCache.ContainsKey(key))
                return mCache[key];

            switch (key)
            { 
                case 'A':
                    mCache[key] = new CharacterA("A");
                    break;
                case 'B':
                    mCache[key] = new CharacterA("B");
                    break;
            }

            return mCache[key];
        }
    }

    public abstract class Character
    {
        public string Name { get; private set; }
        protected Character(string name)
        {
            this.Name = name;
        }

        public abstract void Display();
    }

    public class CharacterA : Character
    {
        public CharacterA(string name)
            : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(this.Name);
        }
    }

    public class CharacterB : Character
    {
        public CharacterB(string name)
            : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(this.Name);
        }
    }
}
