using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;

namespace Kraken.AbilitySystem
{
    public class KASMenuCommands : Editor
    {

        [MenuItem("Kraken/Ability System/Create Initializer", priority = 0)]
        public static void CreateInitter()
        {
            if (EditorSceneManager.GetActiveScene().buildIndex == -1)
            {
                if (EditorUtility.DisplayDialog(
                    "Error creating KAS Initializer",
                    "KAS Initializer is a DDOL (Do Not Destroy On Load) Object and " +
                    "can only be place in your initial scene which can be your splash " +
                    "or a blank scene that initiates your other systems. " +
                    "This \"initializer\" scene should be added to build settings at build index 0 " +
                    "and should be loaded only once and is not to be loaded ever again during runtime " +
                    "since no checks are performed to verify any pre-existing KAS Initializers in the scene.",
                    "OK")) return;
            }

            GameObject _kasinitter = new GameObject();
            _kasinitter.AddComponent<KASInitializer>();
        }

        private static bool _debugEnabled = false;

        internal static bool bIsDebugEnabled { get { return _debugEnabled; } }

        [MenuItem("Kraken/Ability System/Enable Debugging", priority = 11)]
        public static void SetEnableDebugging()
        {
            _debugEnabled = !_debugEnabled;
        }

        [MenuItem("Kraken/Ability System/Enable Debugging", true)]
        public static bool SetEnableDebuggingValidate()
        {
            Menu.SetChecked("Kraken/Ability System/Enable Debugging", _debugEnabled);
            return true;
        }

        [MenuItem("Kraken/Ability System/Open Debugger", priority = 12)]
        public static void OpenKASDebugger()
        {
            EditorWindow wnd = EditorWindow.GetWindow<KASDebuggerWindow>();
            wnd.titleContent = new GUIContent("KAS Debugger");
            wnd.Show();
        }

        [MenuItem("Kraken/Ability System/Open Debugger", true)]
        public static bool OpenKASDebuggerValidate() 
        {
            return _debugEnabled;
        }

    }
}