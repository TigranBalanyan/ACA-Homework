using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_7
{

    /// <summary>
    /// A MultiMap generic collection class that can store more than one value for a Key.
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    public class MultiMap<TKey, TValue> : IDictionary<TKey, List<TValue>>
    {
        public List<TValue> this[TKey key] { get => this.MultiMapContent[key]; set => this.MultiMapContent[key] = value; }
        public ICollection<TKey> Keys { get; set; }
        public ICollection<List<TValue>> Values { get; set; }
        public Dictionary<TKey, List<TValue>> MultiMapContent { get; set; }
        public int Count { get; set; }
        public bool IsReadOnly { get; set; }

        public MultiMap()
        {
            this.MultiMapContent = new Dictionary<TKey, List<TValue>>();
            this.Keys = this.MultiMapContent.Keys;
            this.Values = this.MultiMapContent.Values;
            this.Count = this.MultiMapContent.Count;
            this.IsReadOnly = true;
        }

        /// <summary>
        /// Adds an element to the MultiMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(TKey key, List<TValue> value)
        {
            this.MultiMapContent.Add(key, value);
        }

        /// <summary>
        /// Adds an key value pair to the MultiMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(KeyValuePair<TKey, List<TValue>> item)
        {
            this.MultiMapContent.Add(item.Key, item.Value);
        }

        /// <summary>
        /// Clearing the whole memory of a MultiMap
        /// </summary>
        public void Clear()
        {
            this.MultiMapContent.Clear();
        }

        /// <summary>
        /// Checks if MultiMap contains given item.
        /// </summary>
        /// <param name="item"></param>
        public bool Contains(KeyValuePair<TKey, List<TValue>> item)
        {
            return this.MultiMapContent.Contains(item);
        }

        /// <summary>
        /// Checks if MultiMap contains given key.
        /// </summary>
        /// <param name="key"></param>
        public bool ContainsKey(TKey key)
        {
            return this.MultiMapContent.Keys.Contains(key);
        }

        /// <summary>
        /// Copies the MultiMap to an array from the specified array index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(KeyValuePair<TKey, List<TValue>>[] array, int arrayIndex)
        {
            if(arrayIndex >= 0 && this.MultiMapContent != null)
            {
                array.Take(arrayIndex).Concat(this.MultiMapContent);
            }
        }

        public IEnumerator<KeyValuePair<TKey, List<TValue>>> GetEnumerator()
        {
            return this.MultiMapContent.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        ///Removes the specified key in th MultiMap 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(TKey key)
        {
            return this.MultiMapContent.Remove(key);
        }

        /// <summary>
        /// Removes specified member from the MultiMap
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(KeyValuePair<TKey, List<TValue>> item)
        {
            return this.Remove(item);
        }

        /// <summary>
        /// If possible gets value of the MultiMap
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue(TKey key, out List<TValue> value)
        {
            return this.MultiMapContent.TryGetValue(key, out value);
        }
    }
}
