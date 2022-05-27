using System.Collections;
using System.Text;

namespace LINQToObjects
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
                new Vehicle("Chevrolet", "USA", "Colorado Lt Z85", "Crew Cab", 2010, "1GCJTCDP2A8131132", "Dark Green", "Fine"),
                new Vehicle("Chevrolet", "USA", "Lt Z85", "Crew Cab", 2011, "SOMEVINCODE", "Dark Green", "Fine")
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

            List<VehicleRegistration> vehiclesRegistration = new()
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


            Console.OutputEncoding = Encoding.UTF8;

            // Selecting certain field
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Body style of vehicles");
            var q1 = from x in vehicles
                     select x.bodyStyle;
            Print(q1);

            // Join with inserted query
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("How many drivers can drive certain vehicles");
            var q2 = from x in
                         from y in vehicleDrivers
                         group y by y.vehicleVinCode into grp
                         select new { vehicleVinCode = grp.Key, driversCount = grp.Count() }
                     join f in vehicles on x.vehicleVinCode equals f.vinCode
                     select new { f.mark, f.model, f.releaseYear, x.driversCount };
            Print(q2);

            // Order by
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Drivers sorted by birth date");
            var q3 = from x in drivers
                     orderby x.BirthDate
                     select x.FullName;
            Print(q3);

            // Group
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Vehicles grouped by mark");
            var q4 = from x in vehicles
                     group x.model by x.mark;
            foreach (var g in q4)
            {
                Console.WriteLine($"Vehicles made by {g.Key}");
                Print(g);
            }

            // Join using Where
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Drivers, who can drive certain vehicles");
            var q5 = from x in drivers
                     from y in vehicleDrivers
                     where x.DriverID == y.driverID
                     group new { y.vehicleVinCode, x.FullName } by y.vehicleVinCode;
            foreach (var g in q5)
                Print(g);

            // Filter
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("All vehicles made by Dodge");
            var q6 = from x in vehicles
                     where x.mark == "Dodge"
                     select x;
            Print(q6);

            // Join using Join
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Registration of vehicles");
            var q7 = from x in vehiclesRegistration
                     join y in drivers on x.ownerID equals y.DriverID
                     group new { x.vehicleVinCode, x.numericSign, y.FullName } by x.vehicleVinCode;
            foreach (var g in q7)
                Print(g);

            // Counting by group
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("How many times are vehicles registered");
            var q8 = from x in vehiclesRegistration
                     group x by x.vehicleVinCode into grp
                     select new { vehicleVinCode = grp.Key, registrationCount = grp.Count() };
            Print(q8);

            // Selecting new anonymous type
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Age of vehicles");
            var q9 = from x in vehicles
                     select new { x.mark, x.model, age = DateTime.Now.Year - x.releaseYear };
            Print(q9);

            // List ordered by age
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("All drivers");
            var q10 = from x in drivers
                      orderby x.BirthDate descending
                      select x;
            Print(q10);


            var query0 = from x in vehicles
                      join y in vehiclesRegistration on x.vinCode equals y.vehicleVinCode into g
                      from y in g.DefaultIfEmpty()
                      select new
                      {
                          vehicleVinCode = x.vinCode,
                          ownerID = y == null ? "no owner" : y.ownerID
                      };
            Print(query0);

            var query = from q in query0
                        join d in drivers on q.ownerID equals d.DriverID into g
                        from d in g.DefaultIfEmpty()
                        select new
                        {
                            q.vehicleVinCode,
                            q.ownerID,
                            fullName = d == null ? "no owner" : d.FullName
                        };
            Print(query);

            var query2 = from q in
                             from x in vehicles
                             join y in vehiclesRegistration on x.vinCode equals y.vehicleVinCode into g
                             from y in g.DefaultIfEmpty()
                             select new
                             {
                                 vehicleVinCode = x.vinCode,
                                 ownerID = y == null ? "no owner" : y.ownerID
                             }
                         join d in drivers on q.ownerID equals d.DriverID into g
                         from d in g.DefaultIfEmpty()
                         select new
                         {
                             q.vehicleVinCode,
                             q.ownerID,
                             fullName = d == null ? "no owner" : d.FullName
                         };
            Print(query2);

        }
        static void Print(IEnumerable enumarable)
        {
            foreach (var item in enumarable)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}