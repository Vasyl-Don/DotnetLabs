namespace LINQToObjects
{
    class VehicleRegistration
    {
        public string vehicleVinCode { get; }
        public string ownerID { get; }
        public string numericSign { get; }
        public VehicleRegistration(string vinCode, string ownerID, string numericSign)
        {
            this.vehicleVinCode = vinCode;
            this.ownerID = ownerID;
            this.numericSign = numericSign;
        }
    }
}
