using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]private PlayerCharacter playerCharacter;
    private ScreenViewController _screenViewController;
    
    private void Awake()
    {
        playerCharacter = FindObjectOfType<PlayerCharacter>();
        _screenViewController = gameObject.GetComponent<ScreenViewController>();//TODO more SOLID ?
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            var characters = playerCharacter.SpaceController.GetElementsWithoutCaller();
            _screenViewController.ShowOnlyOneCharacter(characters);
        }
    }
}
