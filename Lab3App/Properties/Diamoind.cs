﻿using System;

public class Diamond : Treasure
{
    public Diamond(string description, int score) : base(description, score)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"{Description} is displayed");
    }
}
