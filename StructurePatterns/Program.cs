namespace StructurePatterns
{
    internal class Program
    {
        // Існує модель системи «Магазин квітів». Реалізувати задачу, що дозволяє
        // додавати до букету новий атрибут(наприклад, стрічку з фірмовою
        // назвою), використовуючи при цьому існуючу модель породження букетів.
        static void Main()
        {
            Bouqet bouqet1 = new("Rose bouqet");
            bouqet1 = new FancyTape(bouqet1);
            bouqet1 = new InscriptionCard(bouqet1, "For my beloved");

            Bouqet bouqet2 = new("Lily bouqet");
            bouqet2 = new FancyTape(bouqet2);
            bouqet2 = new Wrapping(bouqet2);

            Bouqet bouqet3 = new("Tulip bouqet");
            bouqet3 = new Wrapping(bouqet3);
            bouqet3 = new InscriptionCard(bouqet3, "For Vadym");
            bouqet3 = new FancyTape(bouqet3);
        }
    }
}