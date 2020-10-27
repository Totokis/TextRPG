using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

public abstract class RPGTag: Tag
{
    public abstract string Name { get; }


    public abstract void DoSomething(Character target);
}