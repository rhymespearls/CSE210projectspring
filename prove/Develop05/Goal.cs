public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; set; }

    public virtual void MarkComplete()
    {
        IsCompleted = true;
    }

    public abstract void DisplayProgress();
}

