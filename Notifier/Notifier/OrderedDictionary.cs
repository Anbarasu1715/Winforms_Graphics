using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    public class OrderedDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
        private List<KeyValuePair<TKey, TValue>> insertionOrder = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            if (!dictionary.ContainsKey(key))
            {
                insertionOrder.Add(new KeyValuePair<TKey, TValue>(key, value));
                dictionary.Add(key, value);
            }
            else
            {
                throw new ArgumentException("An element with the same key already exists in the dictionary.");
            }
        }

        public TValue this[TKey key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }
        }

        public IEnumerable<TKey> Keys
        {
            get { return dictionary.Keys; }
        }

        public IEnumerable<TValue> Values
        {
            get { return dictionary.Values; }
        }

        public IEnumerable<KeyValuePair<TKey, TValue>> Items
        {
            get { return insertionOrder; }
        }

        public TValue First()
        {
            if (insertionOrder.Count == 0)
            {
                throw new InvalidOperationException("The dictionary is empty.");
            }
            return insertionOrder[0].Value;
        }

        public TValue Last()
        {
            if (insertionOrder.Count == 0)
            {
                throw new InvalidOperationException("The dictionary is empty.");
            }
            return insertionOrder[insertionOrder.Count - 1].Value;
        }

        public void Remove(TKey key)
        {
            if (dictionary.ContainsKey(key))
            {
                var removedItem = insertionOrder.Find(item => EqualityComparer<TKey>.Default.Equals(item.Key, key));
                insertionOrder.Remove(removedItem);
                dictionary.Remove(key);
            }
            else
            {
                //throw new KeyNotFoundException($"The key '{key}' was not found in the dictionary.");
            }
        }

        public int Count()
        {
            return insertionOrder.Count;
        }
    }
}
