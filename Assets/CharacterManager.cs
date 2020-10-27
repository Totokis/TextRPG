using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private List<Character> _listOfCharacters = new List<Character>();
    
    public static CharacterManager Instance { get; private set; }

    public void AddCharacter(Character character)
    {
        _listOfCharacters.Add(character);
    }

    public void ProccesActionsOnCharacters()
    {
        foreach (var character in _listOfCharacters)
        {
            character.CharacterActionController.ProcessAction();
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Character manager destroyed");
        }
    }
}
