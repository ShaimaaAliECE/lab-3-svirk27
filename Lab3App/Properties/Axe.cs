using System;

public class Axe : Tool
{
    public Axe(string description) : base(description)
    {
    }

    public override void DoAction()
    {
        Console.WriteLine("Axe is Used");
    }
}
