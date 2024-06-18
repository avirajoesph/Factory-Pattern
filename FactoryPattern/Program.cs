namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many tires do you want on your vehicle?");
            string userphone = Console.ReadLine();  
            Ivehicle phone = Vehicle_Factory.GetVehicle(userphone);

            phone.Build();
            Console.ReadLine();












        }
    }
}
