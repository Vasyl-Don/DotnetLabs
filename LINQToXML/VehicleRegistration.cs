namespace LINQToXML
{
    class VehicleRegistration
    {
        public string VehicleVinCode { get; }
        public string OwnerID { get; }
        public string NumericSign { get; }
        public VehicleRegistration(string vinCode, string ownerID, string numericSign)
        {
            VehicleVinCode = vinCode;
            OwnerID = ownerID;
            NumericSign = numericSign;
        }
    }
}
