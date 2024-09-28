#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

class GoGoLocoLink : EditorWindow
{

    /**
     *  Show the GoGoLoco project folder in the project view
     */
    [MenuItem("Tools/GoGoLoco/Show Folder")]
    public static void ShowFolder()
    {
        Object asset = AssetDatabase.LoadAssetAtPath<Object>("Packages/gogoloco/Runtime/GoGo/GoLoco/README!.txt");
        EditorGUIUtility.PingObject(asset);
    }
}

#endif