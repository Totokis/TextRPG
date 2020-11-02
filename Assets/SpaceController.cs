using System;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController
{
    private Character _character;
    private Space _space;

    private List<Space> _knownSpaces;

    public SpaceController(Character character)
    {
        _character = character;
    }
    public void AssignToSpace(Space space)
    {
        _space = space;
    }
    public List<Character> GetElements()
    {
       return _space.Characters;
    }
    public List<Character> GetElementsWithoutCaller()
    {
        var list = new List<Character>();
        foreach (var element in _space.Characters)
        {
            if (!element.Equals(_character))
            {
                list.Add(element);
            }
        }
        return list;
    }
}