using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public class NonPlayableCharacter :Character
{
    [SerializeField][TextArea] private string text = "Opis";
    [SerializeField] private new string name ="Człowiek";
    private SpaceController _spaceController;
    
    public override string Text => text;
    public override string Name => name;
    public override SpaceController SpaceController => _spaceController;

    private void Awake()
    {
        _spaceController = new SpaceController(this);
    }
}

public class DialogueController
{
    public Queue<string> Dialogues;
}

