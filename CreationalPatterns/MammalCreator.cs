namespace CreationalPatterns
{
    internal class MammalCreator : AnimalCreator
    {
        public override Animal Create(string kind, string sex, int age, double amountOfFood)
        {
            return new Mammal(kind, sex, age, amountOfFood);
        }
    }
}
