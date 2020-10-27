using UnityEngine;

internal class Eat : CharacterAction
{
    private Character _character;

    public override bool IsFinished
    {
        get => _isFinished;
        set => _isFinished = value;
    }

    private bool _isFinished;
    
    public override void Execute()
    {
        Debug.Log($"{_character.name}--execute CharacterAction {GetType()}");
        CheckFor("eatable");
    }

    private void CheckFor(string name)
    {
        foreach (Thing item in _character.ThingController.GetEquipment())
        {
            Debug.Log($"{_character.name} Looking for item");
            foreach (var tag in item.listOfRPGTags)
            {
                if (tag.Name == name)
                {
                    CharacterAction action = new Use(_character, item, tag);
                    _character.CharacterActionController.EnqueueCharacterAction(action);
                    IsFinished = true;
                    Debug.Log($"{_character.name} Proper item found");
                }
            }
        }
    }

    public Eat(Character character)
    {
        _character = character;
    }
}