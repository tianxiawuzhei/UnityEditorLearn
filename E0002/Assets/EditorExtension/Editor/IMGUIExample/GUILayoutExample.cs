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

        enum PageId
        {
            Basic,
            Other
            
        }

        private int _curPageIdx;
        private string _strTextField = "";
        private string _strTextArea = "";
        private int toolbarInt = 0;
        string[] toolbarStrings = {"Toolbar1", "Toolbar2", "Toolbar3"};
        private void OnGUI()
        {
            _curPageIdx = GUILayout.Toolbar(_curPageIdx, Enum.GetNames(typeof(PageId)));
            if (_curPageIdx == (int)PageId.Basic)
            {
                Basic();
            }
            else
            {
                
            }
            

        }

        #region Basic
        private void Basic()
        {
            GUILayout.BeginVertical("box");
            {
                GUILayout.BeginHorizontal();
                {
                    GUILayout.Label("Label:");
                    GUILayout.Label("Hello");
                }
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                {
                    GUILayout.Label("TextField:");
                    _strTextField = GUILayout.TextField(_strTextField);
                }
                GUILayout.EndHorizontal();

                GUILayout.BeginHorizontal();
                {
                    GUILayout.Label("TextArea:");
                    _strTextArea = GUILayout.TextArea(_strTextArea);
                }
                GUILayout.EndHorizontal();
                
                GUILayout.BeginHorizontal();
                {
                    GUILayout.Label("Button:");
                    if (GUILayout.Button("Button"))
                    {
                        Debug.Log("Button click");
                    }
                }
                GUILayout.EndHorizontal();
                
                GUILayout.BeginHorizontal();
                {
                    GUILayout.Label("RepeatButton:");
                    if (GUILayout.RepeatButton("RepeatButton"))
                    {
                        Debug.Log("RepeatButton click");
                    }
                }
                GUILayout.EndHorizontal();

                toolbarInt = GUILayout.Toolbar(toolbarInt, toolbarStrings);
            }
            GUILayout.EndVertical();
        }
        #endregion
        
        
       
    }
}