using System;
using UnityEngine;

namespace EventDriven.Demo
{
    public class Invoker : MonoBehaviour
    {
        [SerializeField] private Event<int> ev;

        private void Start()
        {
            ev.Invoke(10);
        }
    }
}
