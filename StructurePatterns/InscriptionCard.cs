namespace StructurePatterns
{
    internal class InscriptionCard : BouqetDecorator
    {
        string Inscription { get; }
        public InscriptionCard(Bouqet b, string inscription) : base(b.Name + ", with inscription card", b)
        {
            Inscription = inscription;
        }
    }
}
