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
    public class MultiMap<TKey, TValue> : IDictionary<TKey, TValue>
    {

        public TValue this[TKey key] { get => MultiMapContent[key][0]; set => MultiMapContent[key][0] = value; }

        public ICollection<TKey> Keys { get; set; }

        public ICollection<TValue> Values { get; set; }

        public Dictionary<TKey, List<TValue>> MultiMapContent { get; set; }

        public int Count { get; set; }

        public bool IsReadOnly { get; set; }

        public MultiMap()
        {
            MultiMapContent = new Dictionary<TKey, List<TValue>>();
            Keys = MultiMapContent.Keys;
         //   Values = MultiMapContent;
        }

        /// <summary>
        /// Adds an element to the MultiMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(TKey key, TValue value)
        {
            try
            {
                List<TValue> listItems = null;
                if (MultiMapContent.TryGetValue(key, out listItems))
                {
                    listItems.Add(value);
                }
                else
                {
                    listItems = new List<TValue>();
                    listItems.Add(value);
                    MultiMapContent.Add(key, listItems);
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Adds an key value pair to the MultiMap.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            try
            {
                List<TValue> listItems = null;
                if(MultiMapContent.TryGetValue(item.Key, out listItems))
                {
                    listItems.Add(item.Value);
                }
                else
                {
                    listItems = new List<TValue>();
                    listItems.Add(item.Value);
                    MultiMapContent.Add(item.Key, listItems);
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Clearing the whole memory of a MultiMap
        /// </summary>
        public void Clear()
        {
            MultiMapContent.Clear();
        }

        /// <summary>
        /// Checks if MultiMap contains given item.
        /// </summary>
        /// <param name="item"></param>
        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            List<TValue> listItems = null;
            MultiMapContent.TryGetValue(item.Key, out listItems);
            if (listItems.Contains(item.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if MultiMap contains given key.
        /// </summary>
        /// <param name="key"></param>
        public bool ContainsKey(TKey key)
        {
            return MultiMapContent.Keys.Contains(key);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            foreach(var element in array)
            {
                Console.WriteLine();
            }
            throw new NotImplementedException();
        }   

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///Removes the specified key in th MultiMap 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(TKey key)
        {
            List<TValue> listItems = null;
            if(MultiMapContent.TryGetValue(key, out listItems))
            {
                MultiMapContent.Remove(key);
                return true;
            }
            return false;        
        }

        /// <summary>
        /// Removes specified member from the MultiMap
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            List<TValue> listItems = null;
            if (MultiMapContent.TryGetValue(item.Key, out listItems))
            {
                
                listItems.Remove(item.Value);
                MultiMapContent.Remove(item.Key);
                return true;
            }
            return false;
        }

        /// <summary>
        /// If possible gets value of the MultiMap
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue(TKey key, out TValue value)
        {
            if (MultiMapContent.Keys.Contains(key))
            {
                List<TValue> listItems = null;
                MultiMapContent.TryGetValue(key, out listItems);
                value = listItems[0];
                return true;
            }
            else
            {
                value = default(TValue);
                return false;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
