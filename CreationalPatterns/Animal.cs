namespace CreationalPatterns
{
    public abstract class Animal
    {
        public string Kind;
        public string Sex;
        public int Age;
        public double AmountOfFood;
        public Animal(string kind, string sex, int age, double amountOfFood)
        {
            Kind = kind;
            Sex = sex;
            Age = age;
            AmountOfFood = amountOfFood;
        }
    }
}
