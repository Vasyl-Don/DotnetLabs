namespace LINQToXML
{
    class VehicleDriver
    {
        public string vehicleVinCode { get; }
        public string driverID { get; }
        public VehicleDriver(string vehicleVinCode, string driverID)
        {
            this.driverID = driverID;
            this.vehicleVinCode = vehicleVinCode;
        }
    }
}
