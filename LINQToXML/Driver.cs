using System;

namespace LINQToXML
{
    class Driver
    {
        public string driverID { get; }
        public string fullName { get; }
        public DateTime birthDate { get; }
        public string registrationAddress { get; }
        public Driver(string driverID, string fullName, DateTime birthDate, string registrationAddress)
        {
            this.driverID = driverID;
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.registrationAddress = registrationAddress;
        }
    }
}
