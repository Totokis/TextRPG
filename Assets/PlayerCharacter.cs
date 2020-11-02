using System;
using UnityEngine;

[Serializable]
public class PlayerCharacter : Character
{
    [SerializeField]private string text="Główna postać";
   [SerializeField]private new string name="Postać gracza";
    private SpaceController _spaceController; //where are you nöw
    private ViewController _viewController;
  
    public override string Text => text;
    public override string Name => name;
    public override SpaceController SpaceController => _spaceController;
    
    private void Awake()
    {
        _spaceController = new SpaceController(this);
        _viewController = new ViewController(this);
    }

    
    public void EnableVision()
    {
       DebugWhatPlayerSees();
    }
    
    public void DebugWhatPlayerSees()
    {
        var list = _spaceController.GetElementsWithoutCaller();
        foreach (var element in list)
        {
            Debug.Log(element.name);
        }
    }
}