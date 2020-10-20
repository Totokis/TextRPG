using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Thing))]
public class ThingEditor : Editor
{
    private int _choice;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Thing thing = target as Thing;
        var listOfElements = TagFactory.GetListOfElements();
        
        _choice = EditorGUILayout.Popup(_choice,listOfElements);
        
        if (GUILayout.Button("Add attribute from list"))
        {
            thing.editableList.Add(listOfElements[_choice]);
        }
        thing.editableList = thing.editableList.Distinct().ToList();//removing repeats
        
        EditorGUILayout.LabelField($"This thing is called {thing.name.ToLower()} and has the following attributes: {thing.GetDescription()}" ,GUILayout.Height(150));
        
        if (GUILayout.Button("Bake it !"))
        {
            //thing.BakeToPrefab();
            string localPath = "Assets/" + thing.name + ".prefab";
            localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);
            PrefabUtility.SaveAsPrefabAssetAndConnect(thing.gameObject, localPath, InteractionMode.UserAction);
        }
        
    }
}
