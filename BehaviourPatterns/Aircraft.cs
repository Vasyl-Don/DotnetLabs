namespace BehaviourPatterns
{
    public abstract class Aircraft
    {
        private ITerminal _terminal;
        public int Altitude { get; private set; }
        public string FlightName { get; private set; }

        public Aircraft(ITerminal terminal, string flightName, int altitude)
        {
            FlightName = flightName;
            Altitude = altitude;
            _terminal = terminal;
            _terminal.RegisterAircraftUnderGuidance(this);
        }

        public virtual void Land()
        {
            if (_terminal.ExistsAnotherAircraftWithPriorityToLand(this))
            {
                return;
            }
            _terminal.NotifyAircraftLanding(this);
            _terminal.NotifyAircraftLandingFinished(this);
        }

        internal void WarningAircraftLanding(string flightName)
        { }

        internal void AttentionLandingTrackAvailable()
        { }

        internal void VerifySafeDistance(int altitudeOfAnotherAircraft)
        { }

        public abstract void SetDefaultColor();

        internal void Logging(string message)
        {
            SetDefaultColor();
            Console.WriteLine(message);
            Console.ResetColor();
        }

        internal void ChangeLocation(int newAltitude)
        {
            Altitude += newAltitude;
            _terminal.ReceiveAircraftLocation(this);
        }
    }
}
