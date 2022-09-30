using System;
using System.Collections.Generic;

namespace Puzzle.ServiceLocator
{
    public class ServiceLocator<T>
    {
        private static ServiceLocator<T> instance;

        public static ServiceLocator<T> GetInstance()
        {
            return instance ??= new ServiceLocator<T>();
        }

        private readonly Dictionary<Type, T> serviceDictionary;

        protected ServiceLocator()
        {
            this.serviceDictionary = new Dictionary<Type, T>();
        }
        
        public void RegisterService<K>(K service) where K: T
        {
            Type type = typeof(K);
            this.serviceDictionary.Add(type, service);
        }

        public K GetService<K>() where K: T
        {
            Type type = typeof(K);

            return (K) this.serviceDictionary[type];
        }

        public void UnRegisterService<K>() where K: T
        {
            Type type = typeof(K);
            this.serviceDictionary.Remove(type);
        }
        
        public void Clear()
        {
            this.serviceDictionary.Clear();
        }
    }
}