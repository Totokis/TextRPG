using System.Collections.Generic;
using TMPro;
using UnityEngine;

class ViewController//Probably unnecessary
{
    private PlayerCharacter _character;
    private List<InteractableElement> _interactableElements;//TODO this
    
    public ViewController(PlayerCharacter character)
    {
        _character = character;
    }
}