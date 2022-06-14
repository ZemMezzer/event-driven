using System.Collections.Generic;
using UnityEngine;

namespace EventDriven
{
    public abstract class Event : ScriptableObject
    {
        private readonly HashSet<EventListener> listeners = new HashSet<EventListener>();

        public void Invoke()
        {
            foreach (var listener in listeners)
            {
                listener.Rise();
            }
        }
        
        public void Add(EventListener eventListener)
        {
            listeners.Add(eventListener);
        }

        public void Remove(EventListener eventListener)
        {
            listeners.Remove(eventListener);
        }
    }

    public abstract class Event<T> : ScriptableObject
    {
        private readonly HashSet<EventListener<T>> listeners = new HashSet<EventListener<T>>();

        public void Invoke(T value)
        {
            foreach (var listener in listeners)
            {
                listener.Rise(value);
            }
        }
        
        public void Add(EventListener<T> eventListener)
        {
            listeners.Add(eventListener);
        }

        public void Remove(EventListener<T> eventListener)
        {
            listeners.Remove(eventListener);
        }
    }
    
    public abstract class Event<T1, T2> : ScriptableObject
    {
        private readonly HashSet<EventListener<T1, T2>> listeners = new HashSet<EventListener<T1, T2>>();

        public void Invoke(T1 value1, T2 value2)
        {
            foreach (var listener in listeners)
            {
                listener.Rise(value1, value2);
            }
        }
        
        public void Add(EventListener<T1, T2> eventListener)
        {
            listeners.Add(eventListener);
        }

        public void Remove(EventListener<T1, T2> eventListener)
        {
            listeners.Remove(eventListener);
        }
    }
    
    public abstract class Event<T1, T2, T3> : ScriptableObject
    {
        private readonly HashSet<EventListener<T1, T2, T3>> listeners = new HashSet<EventListener<T1, T2, T3>>();

        public void Invoke(T1 value1, T2 value2, T3 value3)
        {
            foreach (var listener in listeners)
            {
                listener.Rise(value1, value2, value3);
            }
        }
        
        public void Add(EventListener<T1, T2, T3> eventListener)
        {
            listeners.Add(eventListener);
        }

        public void Remove(EventListener<T1, T2, T3> eventListener)
        {
            listeners.Remove(eventListener);
        }
    }
}
