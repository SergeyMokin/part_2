using System;
using System.Collections.Generic;

namespace Part_2
{
    public static class Sorting 
    {
        /// <summary>
        /// Order.
        /// Example: [3, 1, 4] => [1, 3, 4] 
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="collection">Collection to sort</param>
        /// <returns>Ordered collection</returns>
        public static T[] Order<T>(T[] collection)
            where T : IComparable<T>, IComparable
        {
            T temp;
            for (int i = 0; i < collection.Length - 1; i++)
            {
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (collection[i].CompareTo(collection[j])>0)
                    {
                        temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }
                }
            }
            return collection;
        }

        /// <summary>
        /// Order by descending.
        /// Example: [3, 1, 4] => [4, 3, 1] 
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="collection">Collection to sort</param>
        /// <returns>Ordered collection</returns>
        public static T[] DescendingOrder<T>(T[] collection)
            where T : IComparable<T>, IComparable
        {
            // NOTE: do not use LINQ
            // TODO: implement here
            T temp;
            for (int i = 0; i < collection.Length - 1; i++)
            {
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (collection[i].CompareTo(collection[j]) < 0)
                    {
                        temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }
                }
            }
            return collection;
        }

        /// <summary>
        /// Find unique collection elements.
        /// Example: [3, 1, 1, 4, 3, 3, 1, 4] => [3, 1, 4] 
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="collection">Collection to sort</param>
        /// <returns>Ordered collection</returns>
        public static T[] Unique<T>(T[] collection)
        {
            // NOTE: do not use LINQ
            // TODO: implement here
            HashSet<T> hs = new HashSet<T>();
            foreach (T col  in collection)
                if (!hs.Contains(col))
                    hs.Add(col);
               T[] uniqueArr =new T[hs.Count];
            hs.CopyTo(uniqueArr);
            return uniqueArr;
        }
    }
}
