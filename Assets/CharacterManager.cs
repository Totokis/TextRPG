using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private List<Character> _characters;
    
    public List<Character> publicListOfCharacters;

    private void Awake()
    {
        _characters = FindObjectsOfType<Character>().ToList();
        publicListOfCharacters = _characters;
    }
}
