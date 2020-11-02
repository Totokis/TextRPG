using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Character : InteractableElement
{
    public abstract string Text { get; }
    public abstract string Name { get; }
    public abstract SpaceController SpaceController { get; }
}

public abstract class InteractableElement : MonoBehaviour
{
    
}