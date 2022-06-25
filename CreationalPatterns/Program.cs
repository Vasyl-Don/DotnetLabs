namespace CreationalPatterns
{
    class Program
    {
        // Реалізувати завдання «Харчування тварин». Повинна бути
        // реалізована можливість створення різних тварин, із зазначенням
        // наприклад, віку, кількість їжі, котра з'їдається твариною
        static void Main()
        {
            AnimalCreator animalCreator = new MammalCreator();
            Animal bear = animalCreator.Create("White bear", "Male", 4, 12.6d);

            animalCreator = new BirdCreator();
            Animal straus = animalCreator.Create("Straus Emu", "Female", 3, 5d);
        }
    }
}