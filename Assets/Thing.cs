using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour
{
    public new string name = "Noname";
    public List<string> editableList = new List<string>();
    public List<RPGTag> listOfRPGTags = new List<RPGTag>();

    public string GetDescription()
    {
        var description = "";
        foreach (var element in editableList)
        {
            description += $" {element}, \n";
        }

        return description;
    }

    private void Start()
    {
        Debug.Log($"This is {name}");
        BakeToPrefab();
        foreach (var tag in listOfRPGTags)
        {
            Debug.Log($"{name} START--I have inside {tag.Name} !");
        }
    }

    public void BakeToPrefab()
    {
        foreach (var tag in editableList)
        {
            listOfRPGTags.Add(TagFactory.Create(tag));
        }
    }
}
