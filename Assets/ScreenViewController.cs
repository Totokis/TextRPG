using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class ScreenViewController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Name;
    [SerializeField] private TextMeshProUGUI Text;

    private void Awake()
    {
        Name.enabled = false;
        Text.enabled = false;
    }

    public void ShowOnlyOneCharacter(List<Character> characters)
    {
        Name.enabled = true;
        Text.enabled = true;
        var character = characters[0];
        Name.text = character.Name;
        Text.text = character.Text;
    }
}
