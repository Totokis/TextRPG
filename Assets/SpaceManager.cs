using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpaceManager : MonoBehaviour
{
    private List<Space> _spaces;
    //[Description("Only for debbuggin purpose")]
    public  List<Space> publicListOfSpaces;

    private void Awake()
    {
        _spaces = FindObjectsOfType<Space>().ToList();
        publicListOfSpaces = _spaces;
    }
}
