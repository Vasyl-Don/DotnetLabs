namespace CreationalPatterns
{
    public class BirdCreator : AnimalCreator
    {
        public override Animal Create(string kind, string sex, int age, double amountOfFood)
        {
            return new Bird(kind, sex, age, amountOfFood);
        }
    }
}
