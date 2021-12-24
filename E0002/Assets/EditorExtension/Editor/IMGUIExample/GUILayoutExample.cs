using System;
using UnityEditor;
using UnityEngine;

namespace EidtorExtension
{
    public class GUILayoutExample : EditorWindow
    {
        [MenuItem("EditorExtension/02.IMGUI Example/01.OpenGUILayout")]
        static void OpenGUILayoutExample()
        {
            GetWindow<GUILayoutExample>().Show();
        }

        private void OnGUI()
        {
            GUILayout.Label("Hello IMGUI");
        }
    }
}