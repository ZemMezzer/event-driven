using EventDriven.Demo;
using UnityEditor;
using UnityEngine;

namespace EventDriven.Assets.Demo.Editor
{
    [CustomEditor(typeof(Invoker))]
    public class InvokerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            Invoker invoker = (Invoker) target;

            if (GUILayout.Button("Log"))
            {
                invoker.Log();
            }
        }
    }
}
