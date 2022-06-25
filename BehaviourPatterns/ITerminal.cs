namespace BehaviourPatterns
{
    public interface ITerminal
    {
        bool ExistsAnotherAircraftWithPriorityToLand(Aircraft aircraft);
        void ReceiveAircraftLocation(Aircraft aircraft);
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
        void NotifyAircraftLanding(Aircraft aircraft);
        void NotifyAircraftLandingFinished(Aircraft aircraft);
    }
}
