namespace VehicleManagementSystem
{
    interface IVehicle
    {
        void Drive();
    }
    public class truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("driving a truck");
        }

    }
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("driving a car");
        }

    }
    public class VehicleLogger
    {
        private static VehicleLogger instance;
        private VehicleLogger() { }

        public static VehicleLogger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VehicleLogger();
                }
                return instance;
            }
        }
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleLogger logger1 = VehicleLogger.Instance;
            logger1.Log("This is a log message.");
        }
    }
}