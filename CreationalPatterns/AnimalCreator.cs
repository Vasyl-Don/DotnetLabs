namespace CreationalPatterns
{
    public abstract class AnimalCreator
    {
        abstract public Animal Create(string kind, string sex, int age, double amountOfFood);
    }
}
