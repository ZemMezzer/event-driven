using UnityEngine;
using UnityEngine.Events;

namespace EventDriven
{
    public abstract class Event : ScriptableObject
    {
        [SerializeField] private UnityEvent onInvoke;

        public void Invoke()
        {
            onInvoke?.Invoke();
        }

        public void Add(EventListener eventListener)
        {
            onInvoke.AddListener(eventListener.Rise);
        }

        public void Remove(EventListener eventListener)
        {
            onInvoke.RemoveListener(eventListener.Rise);
        }
    }

    public abstract class Event<T> : ScriptableObject
    {
        [SerializeField] private UnityEvent<T> onInvoke;
        
        public void Invoke(T val1)
        {
            onInvoke?.Invoke(val1);
        }
        
        public void Add(EventListener<T> eventListener)
        {
            onInvoke.AddListener(eventListener.Rise);
        }

        public void Remove(EventListener<T> eventListener)
        {
            onInvoke.RemoveListener(eventListener.Rise);
        }
    }
    
    public abstract class Event<T1, T2> : ScriptableObject
    {
        [SerializeField] private UnityEvent<T1, T2> onInvoke;
        
        public void Invoke(T1 val1, T2 val2)
        {
            onInvoke?.Invoke(val1, val2);
        }
        
        public void Add(EventListener<T1, T2> eventListener)
        {
            onInvoke.AddListener(eventListener.Rise);
        }

        public void Remove(EventListener<T1, T2> eventListener)
        {
            onInvoke.RemoveListener(eventListener.Rise);
        }
    }
    
    public abstract class Event<T1, T2, T3> : ScriptableObject
    {
        [SerializeField] private UnityEvent<T1, T2, T3> onInvoke;
        
        public void Invoke(T1 val1, T2 val2, T3 val3)
        {
            onInvoke?.Invoke(val1, val2, val3);
        }
        
        public void Add(EventListener<T1, T2, T3> eventListener)
        {
            onInvoke.AddListener(eventListener.Rise);
        }

        public void Remove(EventListener<T1, T2, T3> eventListener)
        {
            onInvoke.RemoveListener(eventListener.Rise);
        }
    }
}