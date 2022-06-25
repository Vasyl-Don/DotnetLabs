namespace LINQToObjects
{
    public class Vehicle
    {
        public string Mark { get; }
        public string Producer { get; }
        public string Model { get; }
        public string BodyStyle { get; }
        public int ReleaseYear { get; }
        public string VinCode { get; }
        public string Color { get; }
        public string TechnicalCondition { get; }

        public Vehicle(string mark, string producer, string model, string bodyStyle, int releaseYear, string vinCode, string color, string technicalCondition)
        {
            Mark = mark;
            Producer = producer;
            Model = model;
            BodyStyle = bodyStyle;
            ReleaseYear = releaseYear;
            VinCode = vinCode;
            Color = color;
            TechnicalCondition = technicalCondition;
        }
    }
}