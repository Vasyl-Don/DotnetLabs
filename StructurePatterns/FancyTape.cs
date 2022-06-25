namespace StructurePatterns
{
    public class FancyTape : BouqetDecorator
    {
        public FancyTape(Bouqet b) : base (b.Name + ", with fancy tape", b) { }
    }
}
