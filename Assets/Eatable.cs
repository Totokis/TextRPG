using UnityEngine;

public class Eatable : RPGTag
{
    public override string Name => "eatable";
   
    public override void DoSomething(Character target)
    {
        Debug.Log($"----{target.name} just start to eat !!-----");
    }
}