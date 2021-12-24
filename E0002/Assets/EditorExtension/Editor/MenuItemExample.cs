
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
    }
}
