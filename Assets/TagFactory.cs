using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public static class TagFactory
{
    private static Dictionary<string, Type> tagsByName;
    private static bool IsInitialized => tagsByName != null;

    private static void InitializeFactory()
    {
        if(IsInitialized)
            return;

        var tagsTypes = Assembly.GetAssembly(typeof(RPGTag)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(RPGTag)));
        
        tagsByName = new Dictionary<string, Type>();

        foreach (var type in tagsTypes)
        {
            var tempObject = Activator.CreateInstance(type) as RPGTag;
            tagsByName.Add(tempObject.Name, type);
        }
    }

    public static string[] GetListOfElements()
    {
        InitializeFactory();
        var newOne = tagsByName.Keys.ToArray();
        return newOne;
    }

    public static RPGTag Create(string tagName)
    {
        InitializeFactory();
        if (tagsByName.ContainsKey(tagName))
        {
            Type typeOfTag = tagsByName[tagName];
            var tempObject = Activator.CreateInstance(typeOfTag) as RPGTag;
            Debug.Log($"{tagName}- Assembled !");
            return tempObject;
        }
        else
        {
            Debug.Log($"There is no tag like \"{tagName}\"");
            return null;
        }
    }
}
