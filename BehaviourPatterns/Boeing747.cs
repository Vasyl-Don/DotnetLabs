namespace BehaviourPatterns
{
    public class Boeing747 : Aircraft
    {
        public Boeing747(ITerminal terminal, string flightName, int altitude)
            : base(terminal, flightName, altitude)
        {

        }

        public override void SetDefaultColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}
