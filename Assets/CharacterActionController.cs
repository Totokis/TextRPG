using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public  class CharacterActionController
{
    private Queue<CharacterAction> _characterActions= new Queue<CharacterAction>();
    private CharacterAction _currentAction;
    
    public void EnqueueCharacterAction(CharacterAction action)
    {
        _characterActions.Enqueue(action);
    }
    
    public void ProcessAction()
    {
        if (_currentAction != null&&_currentAction.IsFinished == false)
        {
            Debug.Log($"Current action : {_currentAction.GetType()}");
            return;
        }
        if (_characterActions.Any() == false)
        {
            Debug.Log($"Current action : {_currentAction.GetType()}");
            return;
        }
        _currentAction = _characterActions.Dequeue();
        Debug.Log($"Current action : {_currentAction.GetType()}");
        _currentAction.Execute();
    }
    
}