namespace LINQToXML
{
    public class Vehicle
    {
        public string mark { get; }
        public string producer { get; }
        public string model { get; }
        public string bodyStyle { get; }
        public int releaseYear { get; }
        public string vinCode { get; }
        public string color { get; }
        public string technicalCondition { get; }

        public Vehicle(string mark, string producer, string model, string bodyStyle, int releaseYear, string vinCode, string color, string technicalCondition)
        {
            this.mark = mark;
            this.producer = producer;
            this.model = model;
            this.bodyStyle = bodyStyle;
            this.releaseYear = releaseYear;
            this.vinCode = vinCode;
            this.color = color;
            this.technicalCondition = technicalCondition;
        }
    }
}