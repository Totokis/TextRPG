using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    [SerializeField]private string Name = "NoName";
    [SerializeField] private Thing thing;
    private CharacterActionController _characterActionController;
    private ThingController _thingController;
    private DialogueController _dialogueController;
    
    public CharacterActionController CharacterActionController => _characterActionController;
    public ThingController ThingController => _thingController;

    
    private void Start()
    {
        AssignToManager();
        SetDefaultState();
    }

    private void SetDefaultState()
    {
        _thingController = new ThingController();
        _characterActionController = new CharacterActionController();
        var action = new Eat(this);
        _characterActionController.EnqueueCharacterAction(action);
        var thing = this.thing;
        _thingController.AddThingToEquipment(thing);
        
    }
    
    private void AssignToManager()
    {
        FindObjectOfType<CharacterManager>().AddCharacter(this);
        Debug.Log($"{Name}--added");
    }
    
}

public class DialogueController
{
    List<string> dialogueList = new List<string>();
}