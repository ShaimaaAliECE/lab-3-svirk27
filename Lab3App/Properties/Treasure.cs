using System;

public abstract class Treasure : Collectable
{
    public int Score { get; set; }

    protected Treasure(string description, int score) : base(description)
    {
        Score = score;
    }

    public void UpdateTotalScore()
    {
        if (Board != null)
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
    }
}
