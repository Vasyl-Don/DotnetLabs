namespace StructurePatterns
{
    public abstract class BouqetDecorator : Bouqet
    {
        protected Bouqet bouqet;
        public BouqetDecorator(string name, Bouqet bouqet) : base(name)
        {
            this.bouqet = bouqet;
        }
    }
}
