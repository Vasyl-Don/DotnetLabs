using System.Collections;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LINQToXML
{
    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new()
            {
                new Vehicle("Bogdan", "Ukraine", "A092", "Bus", 2003, "1C4BJWDG8DL559834", "Yellow", "Fine"),
                new Vehicle("Dodge", "USA", "Ram 2500", "Crew Cab", 2011, "3D7UT2CL2BG587350", "Silver", "Needs engine repair"),
                new Vehicle("Dodge", "USA", "Nitro Heat", "Sedan", 2011, "1D4PT4GK3BW601989", "White", "Fine"),
                new Vehicle("Buick", "USA", "Lacrosse Cxl", "Sedan", 2010, "1G4GC5EG4AF200592", "White", "Needs engine repair"),
                new Vehicle("Thomas", "USA", "School Bus", "Bus", 2005, "1T88T4C2851152851", "Red", "Needs engine repair"),
                new Vehicle("Dodge", "Canada", "2500 Ram Van", "Cargo Van", 1996, "2B6HB21Y4TK164694", "Black", "Needs transmission repair"),
                new Vehicle("Chevrolet", "USA", "Colorado Lt Z85", "Crew Cab", 2010, "1GCJTCDP2A8131132", "Dark Green", "Fine")
            };

            List<Driver> drivers = new()
            {
                new Driver("526141538", "Donald Martinez", new DateTime(1995, 3, 5), "47 Gray Rd Andover, Massachusetts(MA), 01810"),
                new Driver("261616049", "Sid Mayer", new DateTime(1993, 10, 5), "1950 Bellerive Dr Richland, Washington(WA), 99352"),
                new Driver("839903242", "Cierra Phillips", new DateTime(1998, 11, 29), "4106 E 3rd St Lubbock, Texas(TX), 79403"),
                new Driver("229128341", "John Hadder", new DateTime(1985, 11, 5), "8382 Williams Street, Australia"),
                new Driver("882500096", "Jeramiah Uhler", new DateTime(1997, 7, 9), "2043 Ann Street, Australia"),
                new Driver("576978019", "Alexis Jackson", new DateTime(2001, 12, 1), "1871 Atlantic Avenue, Australia"),
                new Driver("753559019", "Jayden Wesenberg", new DateTime(1997, 6, 22), "1368 Fairway Drive, Australia"),
                new Driver("718238365", "Fred Mabrey", new DateTime(1993, 5, 12), "7314 John Street, Australia"),
                new Driver("892122503", "Henry Wafford", new DateTime(2000, 7, 24), "9745 Atlantic Avenue, Australia"),
                new Driver("857757137", "Douglas Garcia", new DateTime(1995, 8, 22), "5459 Monroe Street, Australia")
            };

            List<VehicleRegistration> vehicleRegistrations = new()
            {
                new VehicleRegistration("1C4BJWDG8DL559834", "526141538", "АВ1457КС"),
                new VehicleRegistration("3D7UT2CL2BG587350", "261616049", "АА1563ОС"),
                new VehicleRegistration("1D4PT4GK3BW601989", "839903242", "ВС4536ПО"),
                new VehicleRegistration("1G4GC5EG4AF200592", "229128341", "ВТ3456КТ"),
                new VehicleRegistration("1T88T4C2851152851", "882500096", "КВ1454КБ"),
                new VehicleRegistration("2B6HB21Y4TK164694", "576978019", "ВР5624БВ"),
                new VehicleRegistration("1GCJTCDP2A8131132", "753559019", "ВК7777ПТ"),
                new VehicleRegistration("1G4GC5EG4AF200592", "839903242", "АМ5792КС"),
                new VehicleRegistration("1T88T4C2851152851", "261616049", "ВС6638ПС"),
                new VehicleRegistration("3D7UT2CL2BG587350", "576978019", "АВ2385КР")
            };
            List<VehicleRegistration> vehiclesRegistration = vehicleRegistrations;

            List<VehicleDriver> vehicleDrivers = new()
            {
                new VehicleDriver("1C4BJWDG8DL559834", "526141538"),
                new VehicleDriver("3D7UT2CL2BG587350", "261616049"),
                new VehicleDriver("1D4PT4GK3BW601989", "839903242"),
                new VehicleDriver("1G4GC5EG4AF200592", "229128341"),
                new VehicleDriver("1T88T4C2851152851", "882500096"),
                new VehicleDriver("2B6HB21Y4TK164694", "576978019"),
                new VehicleDriver("1GCJTCDP2A8131132", "753559019"),
                new VehicleDriver("1G4GC5EG4AF200592", "839903242"),
                new VehicleDriver("1T88T4C2851152851", "261616049"),
                new VehicleDriver("3D7UT2CL2BG587350", "576978019"),
                new VehicleDriver("1T88T4C2851152851", "753559019"),
                new VehicleDriver("1D4PT4GK3BW601989", "718238365"),
                new VehicleDriver("2B6HB21Y4TK164694", "892122503"),
                new VehicleDriver("1GCJTCDP2A8131132", "857757137"),
                new VehicleDriver("1G4GC5EG4AF200592", "892122503")
            };


            XmlWriterSettings settings = new()
            {
                Indent = true
            };

            using (XmlWriter writer = XmlWriter.Create("vehicles.xml", settings))
            {
                writer.WriteStartElement("vehicles");
                foreach (var v in vehicles)
                {
                    writer.WriteStartElement("vehicle");
                    writer.WriteElementString("mark", v.Mark);
                    writer.WriteElementString("producer", v.Producer);
                    writer.WriteElementString("model", v.Model);
                    writer.WriteElementString("bodyStyle", v.BodyStyle);
                    writer.WriteElementString("releaseYear", v.ReleaseYear.ToString());
                    writer.WriteElementString("vinCode", v.VinCode);
                    writer.WriteElementString("color", v.Color);
                    writer.WriteElementString("technicalCondition", v.TechnicalCondition);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

            using (XmlWriter writer1 = XmlWriter.Create("drivers.xml", settings))
            {
                writer1.WriteStartElement("drivers");
                foreach (var d in drivers)
                {
                    writer1.WriteStartElement("driver");
                    writer1.WriteElementString("driverID", d.DriverID);
                    writer1.WriteElementString("fullName", d.FullName);
                    writer1.WriteElementString("birthDate", d.BirthDate.ToString());
                    writer1.WriteElementString("registrationAddress", d.RegistrationAddress);
                    writer1.WriteEndElement();
                }
                writer1.WriteEndElement();
            }

            using (XmlWriter writer2 = XmlWriter.Create("vehicleDrivers.xml", settings))
            {
                writer2.WriteStartElement("vehicleDrivers");
                foreach (var vd in vehicleDrivers)
                {
                    writer2.WriteStartElement("vehicleDriver");
                    writer2.WriteElementString("vehicleVinCode", vd.VehicleVinCode);
                    writer2.WriteElementString("driverID", vd.DriverID);
                    writer2.WriteEndElement();
                }
                writer2.WriteEndElement();
            }

            using (XmlWriter writer3 = XmlWriter.Create("vehiclesRegistration.xml", settings))
            {
                writer3.WriteStartElement("vehiclesRegistration");
                foreach (var vr in vehiclesRegistration)
                {
                    writer3.WriteStartElement("vehicleRegistration");
                    writer3.WriteElementString("vehicleVinCode", vr.VehicleVinCode);
                    writer3.WriteElementString("ownerID", vr.OwnerID);
                    writer3.WriteElementString("numericSign", vr.NumericSign);
                    writer3.WriteEndElement();
                }
                writer3.WriteEndElement();
            }

            XDocument xVehicles = XDocument.Load("vehicles.xml");
            XDocument xDrivers = XDocument.Load("drivers.xml");
            XDocument xVehicleDrivers = XDocument.Load("vehicleDrivers.xml");
            XDocument xVehiclesRegistration = XDocument.Load("vehiclesRegistration.xml");

            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            // Order by
            var q1 = xVehicles.Descendants("vehicle")
                .OrderBy(x => x.Element("mark").Value);
            Print(q1);

            // Selecting certain fields
            var q2 = from x in xDrivers.Element("drivers").Elements("driver")
                     select new
                     {
                         fullName = x.Element("fullName").Value,
                         birthDate = Convert.ToDateTime(x.Element("birthDate").Value)
                     };
            Print(q2);

            // Group with count
            var q3 = from x in xVehicleDrivers.Element("vehicleDrivers").Elements("vehicleDriver")
                     group x by x.Element("vehicleVinCode").Value into vehicle
                     select new
                     {
                         vehicleVinCode = vehicle.Key,
                         driversCount = vehicle.Count()
                     };
            Print(q3);

            // Filtering
            var q4 = from x in xVehiclesRegistration.Element("vehiclesRegistration").Elements("vehicleRegistration")
                     where x.Element("vehicleVinCode").Value == "1GCJTCDP2A8131132"
                     select x;
            Print(q4);

            // Join using where
            var q5 = from x in xVehiclesRegistration.Element("vehiclesRegistration").Elements("vehicleRegistration")
                     from y in xDrivers.Element("drivers").Elements("driver")
                     where x.Element("ownerID").Value == y.Element("driverID").Value
                     orderby x.Element("vehicleVinCode").Value
                     select new
                     {
                         vehicleVinCode = x.Element("vehicleVinCode").Value,
                         fullName = y.Element("fullName").Value
                     };
            Print(q5);

            // Join using join
            var q6 = from x in xVehicleDrivers.Element("vehicleDrivers").Elements("vehicleDriver")
                     join y in xDrivers.Element("drivers").Elements("driver")
                     on x.Element("driverID").Value equals y.Element("driverID").Value
                     orderby y.Element("driverID").Value
                     select new
                     {
                         fullName = y.Element("fullName").Value,
                         vehicleVinCode = x.Element("vehicleVinCode").Value
                     };
            Print(q6);
        }
        static void Print(IEnumerable enumarable)
        {
            foreach (var item in enumarable)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
