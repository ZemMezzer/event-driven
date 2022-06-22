using System;
using EventDriven.Demo.Scripts.PersistantData.Events;
using UnityEngine;

namespace EventDriven.Demo
{
    public class Invoker : MonoBehaviour
    {
        [SerializeField] private string logData;

        [Space]
        
        [SerializeField] private IntEventAsset intEventAsset;
        [SerializeField] private StringEventAsset stringEventAsset;
        
        public void Log()
        {
            if (int.TryParse(logData, out int result))
            {
                intEventAsset.Invoke(result);
                return;
            }
            
            stringEventAsset.Invoke(logData);
        }
    }
}
