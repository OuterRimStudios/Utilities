using System.Collections.Generic;
using UnityEngine;

namespace OuterRimStudios.Utilities
{
    public static class CollectionUtilities
    {
        #region GetRandomItem
        /// <summary></summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns>Returns a random element from the entered array.</returns>
        public static T GetRandomItem<T>(this T[] array)
        {
            return array[Random.Range(0, array.Length)];
        }

        /// <summary></summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>Returns a random element from the entered list.</returns>
        public static T GetRandomItem<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
        #endregion

        #region GetRandomItems
        /// <summary></summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="amount"></param>
        /// <returns>Returns a randomized list of elements from the entered list.</returns>
        public static List<T> GetRandomItems<T>(this List<T> list, int amount)
        {
            List<T> origList = new List<T>();
            foreach (T item in list)
                origList.Add(item);

            List<T> tempList = new List<T>();

            for (int i = amount; i > 0; i--)
            {
                T t = GetRandomItem(origList);
                tempList.Add(t);
                origList.Remove(t);
            }

            return tempList;
        }

        /// <summary></summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="amount"></param>
        /// <returns>Returns a randomized array of elements from the entered array.</returns>
        public static T[] GetRandomItems<T>(this T[] array, int amount)
        {
            List<T> origList = new List<T>();
            foreach (T item in array)
                origList.Add(item);

            List<T> tempList = new List<T>();

            for (int i = amount; i > 0; i--)
            {
                T t = GetRandomItem(origList);
                tempList.Add(t);
                origList.Remove(t);
            }

            return tempList.ToArray();
        }
        #endregion
    }
}