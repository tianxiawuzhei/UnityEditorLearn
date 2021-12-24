
using UnityEditor;
using UnityEngine;

namespace EidtorExtension
{
    public class MenuItemExample : MonoBehaviour
    {
        // Add a menu item named "Do Something" to MyMenu in the menu bar.
        [MenuItem("EditorExtension/01.Example/01.Hello World")]
        static void HelloWorld()
        {
            Debug.Log("Hello World...");
        }

        [MenuItem("EditorExtension/01.Example/02.Open PersistentDataPath")]
        static void OpenPersistentDataPath()
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
            
        }

        [MenuItem("EditorExtension/01.Example/03.Open Costom Folder Library")]
        static void OpenCustomFolder()
        {
            EditorUtility.RevealInFinder(Application.dataPath.Replace("Assets", "Library"));
        }

        private static bool _shortCutSelected = false;
        [MenuItem("EditorExtension/01.Example/04. Toggle Shortcut")]
        static void ToggleShortcut()
        {
            _shortCutSelected = !_shortCutSelected;
            Menu.SetChecked("EditorExtension/01.Example/04. Toggle Shortcut", _shortCutSelected);
        }

        [MenuItem("EditorExtension/01.Example/05. Hello Editor Shortcur _c")]
        static void HelloEditorWithShortcut()
        {
            Debug.Log("Hello Editor Shortcur...");
        }
    }
}
