namespace BehaviourPatterns
{
    internal class Program
    {
        // Реалізувати задачу контролю руху літаків диспетчерами. Самі літаки
        // напряму не взаємодіють один з одним. Повинно бути мінімум
        // 4 злітнопосадкових смуги та 4 термінали. Одночасно на кожній смузі та у
        // кожного терміналу може знаходитись тільки один літак.
        static void Main()
        {
            //Mediator ! All interaction between aircraft must be doing through the traffic controller!
            ITerminal trafficController = new Terminal();

            //Declare Colleagues and associate them with the Air Traffic Controller (Mediator)
            Boeing747 flightA = new Boeing747(trafficController, "Flight A", 2000);
            Boeing747 flightB = new Boeing747(trafficController, "Flight B", 1500);
            Boeing747 flightC = new Boeing747(trafficController, "Flight C", 1460);
            Boeing747 flightD = new Boeing747(trafficController, "Flight D", 1300);

            //flightA wants to land!
            flightA.Land();
            Console.WriteLine();

            //flightB wants to land!
            flightB.Land();
            Console.WriteLine();

            //flight C is moving on 100mts (changing altituded!) 
            flightC.ChangeLocation(100);
            Console.WriteLine();

            //flightD wants to land!
            flightD.Land();
            Console.WriteLine();
        }
    }
}