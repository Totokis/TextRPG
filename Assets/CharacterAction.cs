public abstract class CharacterAction
{
    public abstract bool IsFinished { get; set; }

    public abstract void Execute();
}