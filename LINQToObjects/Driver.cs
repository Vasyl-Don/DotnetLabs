namespace LINQToObjects
{
    class Driver
    {
        public string DriverID { get; }
        public string FullName { get; }
        public DateTime BirthDate { get; }
        public string RegistrationAddress { get; }
        public Driver(string driverID, string fullName, DateTime birthDate, string registrationAddress)
        {
            this.DriverID = driverID;
            this.FullName = fullName;
            this.BirthDate = birthDate;
            this.RegistrationAddress = registrationAddress;
        }
    }
}
