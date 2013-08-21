using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ParalaxObject))]
public class ParalaxObjectEditor : Editor {

	private ParalaxObject that;

    void Awake()
    {
        that = (ParalaxObject)target;
    }

    public override void OnInspectorGUI()
    {
        that.speed.x = EditorGUILayout.Slider("Paralax Speed X:", that.speed.x, -1.0f, 1.0f);
        that.speed.y = EditorGUILayout.Slider("Paralax Speed Y:", that.speed.y, -1.0f, 1.0f);
    }
}
