using UnityEngine;
using UnityEditor;

public class AssetCreator
{
    [MenuItem("Assets/Create Asset from Script", false, 10000)]
    private static void Func()
    {
        var obj = ScriptableObject.CreateInstance(Selection.activeObject.name);
        if (obj == null)
        {
            Debug.LogWarning(Selection.activeObject.name + "のインスタンス生成に失敗しました。");
            return;
        }
        AssetDatabase.CreateAsset(obj, "Assets/" + Selection.activeObject.name + ".asset");
    }

    private static void Log(string str)
    {
        Debug.Log(str);
    }
}
