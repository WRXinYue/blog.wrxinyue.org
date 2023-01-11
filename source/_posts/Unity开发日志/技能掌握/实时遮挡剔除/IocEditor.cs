using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(IOCcam))]
public class IocEditor : Editor {
	
	SerializedProperty LayerMsk;
	SerializedProperty IocTag;
	SerializedProperty Samples;
	SerializedProperty ViewDistance;
	SerializedProperty HideDelay;
	SerializedProperty RealtimeShadows;
	SerializedProperty Lod1Distance;
	SerializedProperty Lod2Distance;
	SerializedProperty LodMargin;
	private Texture2D logo;
	
	void OnEnable() {
		LayerMsk = serializedObject.FindProperty("layerMsk");
		IocTag = serializedObject.FindProperty("iocTag");
		Samples = serializedObject.FindProperty("samples");
		ViewDistance = serializedObject.FindProperty("viewDistance");
		HideDelay = serializedObject.FindProperty("hideDelay");
		RealtimeShadows = serializedObject.FindProperty("realtimeShadows");
		Lod1Distance = serializedObject.FindProperty("lod1Distance");
		Lod2Distance = serializedObject.FindProperty("lod2Distance");
		LodMargin = serializedObject.FindProperty("lodMargin");
		logo = (Texture2D) AssetDatabase.LoadAssetAtPath("Assets/InstantOC/Editor/Images/Logo.jpg", typeof(Texture2D));
	}
	
	override public void OnInspectorGUI () {
		serializedObject.Update();
		
		//GUILayout.Label(logo);
		EditorGUILayout.LabelField("InstantOC parameters", EditorStyles.boldLabel);
		EditorGUILayout.PropertyField(LayerMsk, new GUIContent("Layer mask"));
		IocTag.stringValue = EditorGUILayout.TagField("IOC Tag", IocTag.stringValue);
		EditorGUILayout.IntSlider(Samples, 10, 1500);
		EditorGUILayout.Slider(ViewDistance, 100, 5000);
		EditorGUILayout.IntSlider(HideDelay, 10, 500);
		EditorGUILayout.PropertyField(RealtimeShadows, new GUIContent("Realtime Shadows"));
		EditorGUILayout.Space();
		EditorGUILayout.Slider(Lod1Distance, 0, 1000, new GUIContent("Lod 1 distance"));
		EditorGUILayout.Slider(Lod2Distance, 0, 2000, new GUIContent("Lod 2 distance"));
		EditorGUILayout.PropertyField(LodMargin);
		
		serializedObject.ApplyModifiedProperties();
	}
}
