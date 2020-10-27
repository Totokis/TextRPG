using System;
using UnityEngine;

internal class Use : CharacterAction
{
    private Character _character;
    private Thing _thing;
    private RPGTag _tag;

    public Use(Character character, Thing item, RPGTag tag)
    {
        _character = character;
        _thing = item;
        _tag = tag;
    }

    public override bool IsFinished
    {
        get => _isFinished;
        set => _isFinished = value;
    }

    private bool _isFinished;

    public override void Execute()
    {
        Debug.Log($"{_character.name} use {_thing.name} with tag {_tag.Name}");
        _thing.UseTag(_tag,_character);
        IsFinished = true;
    }
}
