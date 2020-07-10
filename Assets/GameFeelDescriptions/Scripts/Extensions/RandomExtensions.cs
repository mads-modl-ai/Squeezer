using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameFeelDescriptions
{
    public static class RandomExtensions
    {
        public static bool Boolean(float trueProp = 0.5f)
        {
            return Random.value <= trueProp;
        }

        public static int Sign(float posProp = 0.5f)
        {
            return Boolean(posProp) ? 1 : -1;
        }

        /// <summary>
        /// Get a random element from a list.
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetRandomElement<T>(this List<T> list)
        {
            if ((list?.Count > 0) == false) return default;
            
            var index = Random.Range(0, list.Count);
            return list[index];
        }
        
        /// <summary>
        /// Get a random element from the list and remove it from the list.
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T TakeRandomElement<T>(this List<T> list)
        {
            if ((list?.Count > 0) == false) return default;
            
            var index = Random.Range(0, list.Count);
            var element = list[index];
            list.RemoveAt(index);
            return element;
        }
        
        /// <summary>
        /// Get a random element from the array
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetRandomElement<T>(this T[] list)
        {
            if ((list?.Length > 0) == false) return default;
            
            var index = Random.Range(0, list.Length);
            return list[index];

        }
        
        /// <summary>
        /// Get a random element from an System.Array, useful for getting a random element from an Enum <see cref="EnumExtensions.GetRandomValue{T}"/>.
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetRandomElement<T>(this Array list)
        {
            if ((list?.Length > 0) == false) return default;
            
            var index = Random.Range(0, list.Length);
            return (T)list.GetValue(index);
        }
    }
}