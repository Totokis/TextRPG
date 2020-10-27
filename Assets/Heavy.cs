using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heavy : Weight
{
    public override string Name => "heavy";
    public override void DoSomething(Character target)
    {
        throw new System.NotImplementedException();
    }
}
