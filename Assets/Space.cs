using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{

    [SerializeField] private List<Character> charactersInSpace = new List<Character>();
    //private List<Thing> _things; TODO possible things in concrete space, same as above with characters(NPC or Player)
    
    public List<InteractableElement> InteractableElements { get; set; }
    public List<Character> Characters => charactersInSpace;
    private void Start()
    {
        foreach (var character in charactersInSpace)
        {
            character.SpaceController.AssignToSpace(this);
        }
    }
}
