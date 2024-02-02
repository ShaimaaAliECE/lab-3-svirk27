﻿using System.Collections.Generic;
using System;

public abstract class Collectable : Displayable
{
    public string Description { get; set; }
    public CollectionBoard Board { get; set; }

    protected Collectable(string description)
    {
        Description = description;
    }

    public virtual void AddMe(List<Collectable> list)
    {
        list.Add(this);
        Console.WriteLine($"{Description} Collected, Congrats!!!");
        Board?.UpdateTotalScore();
    }

    public abstract void Display();
}
