namespace LINQToXML
{
    class VehicleDriver
    {
        public string VehicleVinCode { get; }
        public string DriverID { get; }
        public VehicleDriver(string vehicleVinCode, string driverID)
        {
            VehicleVinCode = vehicleVinCode;
            DriverID = driverID;
        }
    }
}
