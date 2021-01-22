using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class MyDictionary <TKey, TValue>
    {
        private List<TKey> keyList;
        private List <TValue> valueList;
        private int count;
        public int Count 
        {
            get { return count; }
        }

        public MyDictionary()
        {
            keyList = new List<TKey>();
            valueList = new List<TValue>();
            count = 0;
        }
        public void Add(TKey key, TValue value)
        {

            foreach(TKey keys in keyList)
            {
                if (keyList.Count == 0) break;
                if(key.Equals(keys)) throw new ArgumentException();
            }

            keyList.Add(key);
            valueList.Add(value);

            count++;
        }

        public void Remove(TKey key)
        {
            if (!keyList.Contains(key)) throw new ArgumentException();
            int indexOfKey = keyList.IndexOf(key);
            keyList.Remove(key);
            valueList.Remove(valueList[indexOfKey]);
            count--;
        }

        public TValue GetValue(TKey key)
        {
            int indexOfKey = keyList.IndexOf(key);
            return valueList[indexOfKey];
        }

        public void Clear()
        {
            keyList = new List<TKey>();
            valueList = new List<TValue>();
            count = 0;
        }

    }
}
