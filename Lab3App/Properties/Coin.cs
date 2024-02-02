using System;

public class Coin : Treasure
{
    public int Value { get; set; }

    public Coin(string description, int score, int value) : base(description, score)
    {
        Value = value;
    }

    public void UpdateTotalValue()
    {
        if (Board != null)
        {
            Board.TotalValue += Value;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"{Description} is displayed");
    }
}
