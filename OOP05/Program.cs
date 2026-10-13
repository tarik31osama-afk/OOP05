namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment04

            

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.WriteLine("enter the center name:");
            deliveryCenter.CenterName = Console.ReadLine();

            Console.WriteLine("1-Standard Shipment ");

            Console.WriteLine("tracking code :");
            string trackingCode01 = Console.ReadLine();
            Console.WriteLine("description:");
            string description01 = Console.ReadLine();
            int weight01;
            do
            {
                Console.WriteLine("weight : ");
            }
            while (!int.TryParse(Console.ReadLine(), out weight01));

            decimal deliveryFee01;
            do
            {
                Console.WriteLine("delivery fee :");

            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee01));

            Console.Write("City: ");

            string city01 = Console.ReadLine();

            Console.Write("Street: ");
            string street01 = Console.ReadLine();

            int buildingNumber01;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber01));

            DeliveryAddress destination01 = new DeliveryAddress(city01, street01, buildingNumber01);

            StandardShipment standardShipment = new StandardShipment(trackingCode01, description01, weight01, deliveryFee01, destination01);

            Console.WriteLine("2-ExpressShipment");

            Console.WriteLine("tracking code :");
            string trackingCode02 = Console.ReadLine();
            Console.WriteLine("description:");
            string description02 = Console.ReadLine();
            int weight02;
            do
            {
                Console.WriteLine("weight : ");
            }
            while (!int.TryParse(Console.ReadLine(), out weight02));

            decimal deliveryFee02;
            do
            {
                Console.WriteLine("delivery fee :");

            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee02));

            Console.Write("City: ");

            string city02 = Console.ReadLine();

            Console.Write("Street: ");
            string street02 = Console.ReadLine();

            int buildingNumber02;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber02));

            DeliveryAddress destination02 = new DeliveryAddress(city02, street02, buildingNumber02);
            decimal extrafee;
            do
            {
                Console.WriteLine("extrafee :");
            } while (!decimal.TryParse(Console.ReadLine(), out extrafee));

            ExpressShipment expressShipment = new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02, destination02, extrafee);

            Console.WriteLine("3-InternationalShipment");

            Console.Write("Tracking Code: ");
            string trackingCode03 = Console.ReadLine();

            Console.Write("Description: ");
            string description03 = Console.ReadLine();

            int weight03;
            do
            {
                Console.Write("Weight: ");

            }
            while (!int.TryParse(Console.ReadLine(), out weight03));

            decimal deliveryFee03;
            do
            {
                Console.Write("Delivery Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee03));

            Console.Write("City: ");

            string city03 = Console.ReadLine();

            Console.Write("Street: ");
            string street03 = Console.ReadLine();

            int buildingNumber03;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber03));

            DeliveryAddress destination03 = new DeliveryAddress(city03, street03, buildingNumber03);

            Console.WriteLine("destination country : ");

            string destinationCountry = Console.ReadLine();

            decimal customsfee;
            do
            {
                Console.WriteLine("customerfee :");
            } while (!decimal.TryParse(Console.ReadLine(), out customsfee));

            InternationalShipment internationalShipment = new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03, destination03, destinationCountry, customsfee);

            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(internationalShipment);
            deliveryCenter.AddShipment(expressShipment);

            deliveryCenter.PrintAllShipments();

            deliveryCenter.PrintTrackingStatuses();

            Console.WriteLine(standardShipment.CalculateInsurance());
            Console.WriteLine( internationalShipment.CalculateInsurance());
            Console.WriteLine(expressShipment.CalculateInsurance());

            ITrackable[] shipTrack =
            {
                standardShipment,internationalShipment, expressShipment
            };
            for (int i = 0; i < shipTrack.Length; i++)
            {
                Console.WriteLine(shipTrack[i].GetTrackingStatus()); 
            }
            IInsurable[]insurables =
            {
                standardShipment,internationalShipment, expressShipment
            };
            
            for (int i = 0; i < insurables.Length; i++)
            {
                Console.WriteLine(insurables[i].CalculateInsurance());
            }
            #endregion

            #region part01 assignment05

            #region q1
            //a) Both variables refer to the same object in memory
            //b) No. It only copies the reference to the existing object
            //c) Copying an object creates a new object in memory but copying its reference makes two variables point to the same object

            #endregion

            #region q2
            //a) A Shallow Copy creates a new object but shares references to nested objects with the original
            //b) A Deep Copy creates a new object and independent copies of its nested objects
            //c) Their references are copied so both objects refer to the same object
            //d) Independent copies of object so changes to one do not affect the other
            //e)When copying a shipment that contains a delivery address,
            //  Deep Copy is safer because changing the copied shipment's address will not affect the original shipment
            #endregion

            #region q3

            //a) A static field belongs to the class and is shared by all objects but instance field belongs to each object
            //b) A static method belongs to the class and can be called without creating an object ,no it cannot directly access instance members
            //c) A static constructor initializes the class's static data. It runs automatically only once, before the class is first used
            //d) A static class contains only static members, No you cannot create an object from a static class

            #endregion

            #region q4
            //a)An Extension Method allows us to add new method-like functionality to an existing type without modifying its original code or inheriting from it
            //b) this
            //c) It must be declared in static class
            //d) No It cannot directly access private members because it is not actually part of the original class
            #endregion

            #endregion




        }
    }
}
 