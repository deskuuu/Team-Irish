namespace Common.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Contracts;

    public class DataContainer<T> : ICollection, IList where T : IBaseNote
    {
        private const int DefaultCapacity = 2;

        private int counter = -1;
        private IList<T> dataList = new List<T>();

        public object this[int index]
        {
            get
            {
                return this.dataList[index];
            }
            set
            {
                this.dataList[index] = (T)value;
            }
        }

        public int Count => this.dataList.Count;

        public bool IsFixedSize => false;

        public bool IsReadOnly => false;

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Add(object value)
        {
            if (dataList.Count < DefaultCapacity)
            {
                dataList[counter] = (T)value;// doesnt work
                counter++;

                return counter - 1;
            }
            else
            {
                return -1;
            }
        }

        public void Clear()
        {
            this.dataList.Clear();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}