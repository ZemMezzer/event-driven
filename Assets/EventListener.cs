using System;
using UnityEngine;
using UnityEngine.Events;

namespace EventDriven
{
    public abstract class EventListenerBase : MonoBehaviour
    {
        [SerializeField] private bool useOnEnableOnDisable;
        
        private void Awake()
        {
            if(useOnEnableOnDisable)
                return;
            
            Subscribe();
        }

        private void OnDestroy()
        {
            if(useOnEnableOnDisable)
                return;
            
            Unsubscribe();
        }

        private void OnEnable()
        {
            if(!useOnEnableOnDisable)
                return;
            
            Subscribe();
        }

        private void OnDisable()
        {
            if(!useOnEnableOnDisable)
                return;
            
            Unsubscribe();
        }

        protected abstract void Subscribe();
        protected abstract void Unsubscribe();
    }
    
    public class EventListener : EventListenerBase
    {
        [SerializeField] private Event[] events;
        [SerializeField] private UnityEvent onRise;

        protected override void Subscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Add(this);
            }
        }

        protected override void Unsubscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Remove(this);
            }
        }

        public void Rise()
        {
            onRise.Invoke();
        }
    }

    public class EventListener<T> : EventListenerBase
    {
        [SerializeField] private Event<T>[] events;
        [SerializeField] private UnityEvent<T> onRise;
        
        protected override void Subscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Add(this);
            }
        }

        protected override void Unsubscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Remove(this);
            }
        }
        
        public void Rise(T value)
        {
            onRise.Invoke(value);
        }
    }
    
    public class EventListener<T1, T2> : EventListenerBase
    {
        [SerializeField] private Event<T1, T2>[] events;
        [SerializeField] private UnityEvent<T1, T2> onRise;
        
        protected override void Subscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Add(this);
            }
        }

        protected override void Unsubscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Remove(this);
            }
        }
        
        public void Rise(T1 value1, T2 value2)
        {
            onRise.Invoke(value1, value2);
        }
    }
    
    public class EventListener<T1, T2, T3> : EventListenerBase
    {
        [SerializeField] private Event<T1, T2, T3>[] events;
        [SerializeField] private UnityEvent<T1, T2, T3> onRise;
        
        protected override void Subscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Add(this);
            }
        }

        protected override void Unsubscribe()
        {
            foreach (var eventAsset in events)
            {
                eventAsset.Remove(this);
            }
        }
        
        public void Rise(T1 value1, T2 value2, T3 value3)
        {
            onRise.Invoke(value1, value2, value3);
        }
    }
}
