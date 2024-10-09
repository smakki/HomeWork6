namespace HomeWork6
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components;
        public Quadcopter()
        {
            _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
        }
            public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents()
        {
            return _components;
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
