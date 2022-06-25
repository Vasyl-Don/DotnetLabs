namespace BehaviourPatterns
{
    public class Terminal : ITerminal
    {
        private readonly List<Aircraft> _aircrafts;

        public Terminal()
        {
            _aircrafts = new List<Aircraft>();
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft); // Registering new colleague
        }

        public void NotifyAircraftLanding(Aircraft aircraft)
        {
            foreach (var receivingAircraft in _aircrafts.Where(a => a != aircraft))
            {
                receivingAircraft.WarningAircraftLanding(aircraft.FlightName); // Sending a message to colleagues
            }
        }

        public void NotifyAircraftLandingFinished(Aircraft aircraft)
        {
            foreach (var receivingAircraft in _aircrafts.Where(a => a != aircraft))
            {
                receivingAircraft.AttentionLandingTrackAvailable();
            }
        }

        public bool ExistsAnotherAircraftWithPriorityToLand(Aircraft sender)
        {
            bool existsAircraftWithMorePriorityToLand = false;

            foreach (var aircraft in _aircrafts.Where(a => a != sender))
            {
                if (aircraft.Altitude <= sender.Altitude)
                {
                    existsAircraftWithMorePriorityToLand = true;
                    break;
                }
            }

            return existsAircraftWithMorePriorityToLand;
        }


        public void ReceiveAircraftLocation(Aircraft aircraft)
        {
            foreach (var receivingAircraft in _aircrafts.Where(a => a != aircraft))
            {
                receivingAircraft.VerifySafeDistance(aircraft.Altitude);
            }
        }
    }
}
