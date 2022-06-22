using UnityEngine;

namespace EventDriven.Demo
{
    public class Logger : MonoBehaviour
    {
        public void LogInt(int value)
        {
            Debug.Log($"Log Int Value: \"{value.ToString()}\"");
        }

        public void StringLog(string value)
        {
            Debug.Log($"Log String Value: \"{value}\"");
        }
    }
}
