namespace StructurePatterns
{
    public class Wrapping : BouqetDecorator
    {
        public Wrapping(Bouqet b) : base(b.Name + ", with wrapping", b) { }
    }
}
