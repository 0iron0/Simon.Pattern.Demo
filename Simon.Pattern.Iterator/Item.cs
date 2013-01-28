using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Simon.Pattern.Iterator
{
    /// <summary>
    /// yield关键字
    /// </summary>
    public class Item
    {
        public string Name { get; set; }
        public int Size { get; set; }
    }

    public class ItemCollection : CollectionBase, IEnumerable
    {
        public Item this[int index]
        {
            get
            {
                return List[index] as Item;
            }
        }

        public int Add(Item item)
        {
            return List.Add(item);
        }

        public void Remove(Item item)
        {
            List.Remove(item);
        }

        public new IEnumerator GetEnumerator()
        {
            return new ItemEnumerator(this);
        }
    }

    public class ItemEnumerator : IEnumerator
    {
        private ItemCollection mItems;
        private int mPosition = -1;

        public ItemEnumerator(ItemCollection items)
        {
            this.mItems = items;
        }

        public object Current
        {
            get 
            { 
                return this.mItems[this.mPosition];
            }
        }

        public bool MoveNext()
        {
            if (this.mPosition < this.mItems.Count - 1)
            {
                this.mPosition++;
                return true;
            }
         
            return false;
        }

        public void Reset()
        {
            mPosition = -1;
        }
    }

    public class Collection<T> : IEnumerable<T>
    {
        private List<T> mList = new List<T>();

        public void Add(T t)
        {
            this.mList.Add(t);
        }

        public void Remove(T t)
        {
            this.mList.Remove(t);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CollectionEnumerator<T>(this.mList);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CollectionEnumerator<T> : IEnumerator<T>
    {
        int mPosition = -1;
        List<T> mList;

        public CollectionEnumerator(List<T> list)
        {
            this.mList = list;
        }

        public T Current
        {
            get { return this.mList[this.mPosition]; }
        }

        public void Dispose()
        {
            GC.Collect();
        }

        object IEnumerator.Current
        {
            get { return this.mList[this.mPosition]; }
        }

        public bool MoveNext()
        {
            if (this.mPosition < this.mList.Count - 1)
            {
                this.mPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            this.mPosition = -1;
        }
    }
}
